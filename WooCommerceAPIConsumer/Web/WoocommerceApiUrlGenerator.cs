namespace SharpCommerce.Web
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    internal class WoocommerceApiUrlGenerator
    {
        private const string SignatureMethod = "HMAC-SHA1";
        private const string ApiV3RootEndpoint = "wc-api/v3/";
        private readonly string baseURI;
        private readonly string consumerKey;
        private readonly string consumerSecret;

        internal WoocommerceApiUrlGenerator(string storeUrl, string consumerKey, string consumerSecret)
        {
            if (
                string.IsNullOrEmpty(consumerKey) ||
                string.IsNullOrEmpty(consumerSecret) ||
                string.IsNullOrEmpty(storeUrl))
            {
                throw new ArgumentException("ConsumerKey, consumerSecret and storeUrl are required");
            }

            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;

            // Need 'http://www.example.com' to be 'http://www.example.com/wc-api/v3/'
            this.baseURI = String.Format("{0}/{1}", storeUrl.TrimEnd('/'), ApiV3RootEndpoint);
        }

        internal string GenerateRequestUrl(HttpMethod httpMethod, string apiEndpoint, Dictionary<string, string> parameters = null)
        {
            parameters = parameters ?? new Dictionary<string, string>();

            parameters["oauth_consumer_key"] = this.consumerKey;

            // oauth_timestamp = number of seconds since 1/1/1970 00:00:00 GMT
            // must be a positive integer
            // must be greater than timestamp of previous requests
            parameters["oauth_timestamp"] =
                Math.Round(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds).ToString(CultureInfo.InvariantCulture);

            // oauth_nonce = a unique random string for the timestamp.
            // defends against replay attacks
            // service provide will know that this request has never been made before.
            // Just going to hash the time stamp.
            //parameters["oauth_nonce"] = GenerateNonce(parameters["oauth_timestamp"]);
            
            // Create random 32 char alphnumeric to avoid reused nonces
            parameters["oauth_nonce"] = GenerateNonce();

            // Declare the hashing method your using
            parameters["oauth_signature_method"] = SignatureMethod;

            //parameters["oauth_version"] = "1.0";

            parameters["oauth_signature"] = UpperCaseUrlEncode(this.GenerateSignature(httpMethod, apiEndpoint, parameters));


            var sb = new StringBuilder();
            foreach (var pair in parameters)
            {
                sb.AppendFormat("&{0}={1}", SafeUpperCaseUrlEncode(pair.Key), SafeUpperCaseUrlEncode(pair.Value));
            }

            // Substring removes first '&'
            var queryString = sb.ToString().Substring(1);

            var url = this.baseURI + apiEndpoint + "?" + queryString;
            
            return url;
        }

        private string GenerateSignature(HttpMethod httpMethod, string apiEndpoint, Dictionary<string, string> parameters)
        {
            // 1) Set the HTTP method for the request.
            // set through 'method'


            //2) Set your base request URI – this is the full request URI without query string parameters – and URL encode according to RFC 3986:
            // need 'http://www.example.com/wc-api/v3/orders'
            // to become: 'http%3A%2F%2Fwww.example.com%2Fwc-api%2Fv1%2Forders'
            var encodedBaseRequestURI = SafeUpperCaseUrlEncode(this.baseURI + apiEndpoint);

            // 3) Collect and normalize your query string parameters
            // percent(%) characters should be double-encoded (e.g. % becomes %25.
            var normalizedParameters = NormalizeParameters(parameters);

            // 4) Sort the parameters in byte-order
            var orderedNormalizedParameters = normalizedParameters.OrderBy(x => x.Key).ToList();

            // 5) Join each parameter with an encoded equals sign (%3D):
            var joinedOrderedNormalizedParameters = orderedNormalizedParameters.ConvertAll(x => x.Key + "%3D" + x.Value);

            // 6) Join each parameter key/value pair with an encoded ampersand (%26):
            var joinedParameterPairs = String.Join("%26", joinedOrderedNormalizedParameters);

            // 7) Form the string to sign by joining the HTTP method, encoded base request URI, and encoded parameter string with an unencoded ampersand symbol (&):
            var stringToSign = string.Format("{0}&{1}&{2}", httpMethod.ToString().ToUpper(), encodedBaseRequestURI, joinedParameterPairs);

            // 8) Generate the signature using the string to key and your consumer secret key
            var preparedStringToSign = Encoding.UTF8.GetBytes(stringToSign);
            var secret = this.consumerSecret + "&";
            var preparedConsumerKey = Encoding.UTF8.GetBytes(secret);
            var signatureHash = Sha1(preparedConsumerKey, preparedStringToSign);
            var signatureString = Convert.ToBase64String(signatureHash);

            return signatureString;
        }

        private static byte[] Sha1(byte[] key, byte[] message)
        {
            var hash = new HMACSHA1(key);
            return hash.ComputeHash(message);
        }

        private static string GenerateNonce(string input)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var stringBuilder = new StringBuilder();

                foreach (var b in hash)
                {
                    stringBuilder.Append(b.ToString(CultureInfo.InvariantCulture));
                }

                return stringBuilder.ToString();
            }
        }

        private static Dictionary<string, string> NormalizeParameters(Dictionary<string, string> parameters)
        {
            var result = new Dictionary<string, string>();
            foreach (var pair in parameters)
            {
                var upperCaseUrlEncodedKey = SafeUpperCaseUrlEncode(pair.Key);
                var normalizedKey = upperCaseUrlEncodedKey.Replace("%", "%25");

                var upperCaseUrlEncodedValue = SafeUpperCaseUrlEncode(pair.Value);
                var normalizedValue = upperCaseUrlEncodedValue.Replace("%", "%25");

                result.Add(normalizedKey, normalizedValue);
            }

            return result;
        }

        private static string SafeUpperCaseUrlEncode(string stringToEncode)
        {
            return UpperCaseUrlEncode(HttpUtility.UrlDecode(stringToEncode));
        }

        private static string UpperCaseUrlEncode(string stringToEncode)
        {
            var basicUrlEncodedString = HttpUtility.UrlEncode(stringToEncode);

            if (String.IsNullOrEmpty(basicUrlEncodedString)) return String.Empty;

            var upperCaseUrlEncodedString = Regex.Replace(
                basicUrlEncodedString,
                "(%[0-9a-f][0-9a-f])",
                c => c.Value.ToUpper());

            return upperCaseUrlEncodedString;
        }

        private static string GenerateNonce()
        {
            const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();

            var nonceString = new StringBuilder();
            for (var i = 0; i < 32; i++)
            {
                nonceString.Append(ValidChars[random.Next(0, ValidChars.Length - 1)]);
            }
 
            return nonceString.ToString();
        }
    }
}

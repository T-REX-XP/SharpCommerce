namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class PaymentDetails
    {
        [JsonProperty("method_id")]
        public string MethodId { get; set; }

        [JsonProperty("method_title")]
        public string MethodTitle { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}

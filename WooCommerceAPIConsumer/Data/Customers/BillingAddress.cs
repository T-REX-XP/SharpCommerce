namespace SharpCommerce.Data.Customers
{
    using Newtonsoft.Json;

    public class BillingAddress : Address
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

    }
}

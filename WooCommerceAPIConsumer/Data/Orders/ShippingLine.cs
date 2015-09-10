namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class ShippingLine
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("method_id")]
        public string MethodId { get; set; }

        [JsonProperty("method_title")]
        public string MethodTitle { get; set; }

        [JsonProperty("total")]
        public float Total { get; set; }
    }
}

namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class CouponLine
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }
    }
}

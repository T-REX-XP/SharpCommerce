namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class TaxLine
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rate_id")]
        public int RateId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total")]
        public float Total { get; set; }

        [JsonProperty("compound")]
        public bool Compound { get; set; }
    }
}

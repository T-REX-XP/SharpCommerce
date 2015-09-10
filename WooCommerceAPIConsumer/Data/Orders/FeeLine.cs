namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class FeeLine
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("total")]
        public float Total { get; set; }

        [JsonProperty("total_tax")]
        public float TotalTax { get; set; }
    }
}

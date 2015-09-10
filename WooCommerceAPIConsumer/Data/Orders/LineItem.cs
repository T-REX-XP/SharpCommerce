namespace SharpCommerce.Data.Orders
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class LineItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("subtotal")]
        public float Subtotal { get; set; }

        [JsonProperty("subtotal_tax")]
        public float SubtotalTax { get; set; }

        [JsonProperty("total")]
        public float Total { get; set; }

        [JsonProperty("total_tax")]
        public float TotalTax { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("meta")]
        public IEnumerable<MetaItem> Meta { get; set; }

        [JsonProperty("variations")]
        public IEnumerable<Variation> Variations { get; set; } 

    }
}

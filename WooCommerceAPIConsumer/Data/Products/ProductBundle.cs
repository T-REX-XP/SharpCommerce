namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductBundle
    {
        [JsonProperty("product")]
        public Product Content { get; set; }
    }
}

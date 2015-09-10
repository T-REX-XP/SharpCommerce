using System.Collections.Generic;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductsBundle
    {
        [JsonProperty("products")]
        public IEnumerable<Product> Content { get; set; }
    }
}

using System.Collections.Generic;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductReviewsBundle
    {
        [JsonProperty("product_reviews")]
        public IEnumerable<ProductReview> Content { get; set; }
    }
}

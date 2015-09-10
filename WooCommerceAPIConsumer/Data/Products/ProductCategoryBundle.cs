using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductCategoryBundle
    {
        [JsonProperty("product_category")]
        public ProductCategory Content { get; set; }
    }
}
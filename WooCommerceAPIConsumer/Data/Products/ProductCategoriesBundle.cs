using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductCategoriesBundle
    {
        [JsonProperty("product_categories")]
        public IEnumerable<ProductCategory> Content { get; set; }
    }
}

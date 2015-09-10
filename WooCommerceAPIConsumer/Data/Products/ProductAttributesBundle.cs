using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;
    
    internal class ProductAttributesBundle
    {
        [JsonProperty("product_attributes")]
        public IEnumerable<ProductAttribute> Content { get; set; }
    }
}

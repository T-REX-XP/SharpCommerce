using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    internal class ProductAttributeBundle
    {
        [JsonProperty("product_attribute")]
        public ProductAttribute Content { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class ProductAttribute
    {
        /// <summary>
        /// Attribute ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Attribute name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Attribute type, the types available include by default are: select and text (some plugins can include new types)
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Default sort order. Available: menu_order, name, name_num and id        
        /// </summary>
        [JsonProperty("order_by")]
        public bool OrderBy { get; set; }

        /// <summary>
        /// Enable/Disable attribute archives
        /// </summary>
        [JsonProperty("has_archives")]
        public bool HasArchives { get; set; }
    }
}

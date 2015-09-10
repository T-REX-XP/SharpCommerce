using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class Attribute
    {
        /// <summary>
        /// Attribute name [required]
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Attribute position
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Shows/define if the attribute is visible on the “Additional Information” tab in the product’s page
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// Shows/define if the attribute can be used as variation
        /// </summary>
        [JsonProperty("variation")]
        public bool Variation { get; set; }

        /// <summary>
        /// List of available term names of the attribute
        /// </summary>
        [JsonProperty("options")]
        public string[] Options { get; set; }
    }
}

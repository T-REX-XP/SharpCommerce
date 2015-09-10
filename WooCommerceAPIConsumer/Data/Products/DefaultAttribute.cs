using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class DefaultAttribute
    {
        /// <summary>
        /// Attribute name
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [JsonProperty("slug")]
        string Slug { get; set; }

        /// <summary>
        /// Selected term name of the attribute
        /// </summary>
        [JsonProperty("option")]
        string Option { get; set; }
    }
}

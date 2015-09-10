using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class Dimensions
    {
        /// <summary>
        /// Product length in decimal format
        /// </summary>
        [JsonProperty("length")]
        public float Length { get; set; }

        /// <summary>
        /// Product width in decimal format
        /// </summary>
        [JsonProperty("width")]
        public float Width { get; set; }

        /// <summary>
        /// Product height in decimal format
        /// </summary>
        [JsonProperty("height")]
        public float Height { get; set; }

        /// <summary>
        /// Product name [read-only]
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}

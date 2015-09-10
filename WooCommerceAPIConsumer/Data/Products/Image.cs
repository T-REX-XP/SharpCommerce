using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class Image
    {
        /// <summary>
        /// Image ID (attachment ID)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UTC DateTime when the image was created. [read-only]
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the image was last updated. [read-only]
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Image URL. In write-mode you can use to send new images.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Image title (attachment title). [read-only]
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Image alt text (attachment image alt text). [read-only]
        /// </summary>
        [JsonProperty("alt")]
        public string Alt { get; set; }

        /// <summary>
        /// Image position. 0 means that the image is featured.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }
    }
}

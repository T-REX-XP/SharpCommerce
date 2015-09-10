using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using Newtonsoft.Json;

    public class ProductReview
    {
        /// <summary>
        /// Review ID (comment ID) read-only
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UTC DateTime when the review was created read-only
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Review rating (0 to 5) read-only
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Reviewer name read-only
        /// </summary>
        [JsonProperty("reviewer_name")]
        public string ReviewerName { get; set; }

        /// <summary>
        /// Reviewer email read-only
        /// </summary>
        [JsonProperty("reviewer_email")]
        public string ReviewerEmail { get; set; }

        /// <summary>
        /// Shows if the reviewer bought the product or not
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}

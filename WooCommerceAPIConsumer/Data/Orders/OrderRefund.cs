namespace SharpCommerce.Data.Orders
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class OrderRefund
    {
        /// <summary>
        /// Order note ID [read-only]
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UTC DateTime when the order refund was created [read-only]
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Refund amount  [required]
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// Reason for refund
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// List of order items to refund. See <see cref="LineItem"/> class.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<LineItem> LineItems { get; set; }
    }
}

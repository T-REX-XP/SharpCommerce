namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    public class OrderStatuses
    {
        [JsonProperty("pending")]
        public string Pending { get; set; }

        [JsonProperty("processing")]
        public string Processing { get; set; }

        [JsonProperty("on-hold")]
        public string OnHold { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("cancelled")]
        public string Cancelled { get; set; }

        [JsonProperty("refunded")]
        public string Refunded { get; set; }

        [JsonProperty("failed")]
        public string Failed { get; set; }

    }

}

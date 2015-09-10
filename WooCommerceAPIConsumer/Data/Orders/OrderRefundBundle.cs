namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    internal class OrderRefundBundle
    {
        [JsonProperty("order_refund")]
        public OrderRefund Content { get; set; }
    }
}

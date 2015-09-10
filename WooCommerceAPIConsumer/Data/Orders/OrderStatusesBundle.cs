namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    internal class OrderStatusesBundle
    {
        [JsonProperty("order_statuses")]
        public OrderStatuses Content { get; set; }
    }
}

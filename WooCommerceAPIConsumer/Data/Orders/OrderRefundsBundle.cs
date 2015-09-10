namespace SharpCommerce.Data.Orders
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderRefundsBundle
    {
        [JsonProperty("order_refunds")]
        public IEnumerable<OrderRefund> Content { get; set; }
    }
}

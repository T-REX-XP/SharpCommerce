using System.Collections.Generic;

namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    internal class OrdersBundle
    {
        [JsonProperty("orders")]
        public IEnumerable<Order> Content { get; set; }
    }
}

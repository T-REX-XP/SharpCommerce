namespace SharpCommerce.Data.Orders
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderNotesBundle
    {
        [JsonProperty("order_notes")]
        public IEnumerable<OrderNote> Content { get; set; }
    }
}

namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    internal class OrderNoteBundle
    {
        [JsonProperty("order_note")]
        public OrderNote Content { get; set; }
    }
}

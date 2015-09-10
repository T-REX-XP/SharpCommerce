namespace SharpCommerce.Data.Orders
{
    using Newtonsoft.Json;

    internal class OrderBundle
    {
        [JsonProperty("order")]
        public Order Content { get; set; }
    }
}
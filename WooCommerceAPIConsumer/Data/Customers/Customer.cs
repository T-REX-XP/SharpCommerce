namespace SharpCommerce.Data.Customers
{
    using System;

    using Newtonsoft.Json;

    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }


        [JsonProperty("first_name")]
        public string FirstName { get; set; }


        [JsonProperty("last_name")]
        public string LastName { get; set; }


        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("last_order_id")]
        public int LastOrderId { get; set; }

        [JsonProperty("last_order_date")]
        public DateTime LastOrderDate { get; set; }


        [JsonProperty("orders_count")]
        public int OrdersCount { get; set; }


        [JsonProperty("total_spent")]
        public float TotalSpent { get; set; }


        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }
}

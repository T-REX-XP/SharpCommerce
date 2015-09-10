namespace SharpCommerce.Data.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    using SharpCommerce.Data.Customers;



    [DataContract]
    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("completed_at")]
        public DateTime CompletedAt { get; set; }

        [JsonProperty("status")]
        public OrderStatus Status { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("total")]
        public float Total { get; set; }

        [JsonProperty("subtotal")]
        public float Subtotal { get; set; }

        [JsonProperty("total_line_items_quantity")]
        public int TotalLineItemsQuantity { get; set; }

        [JsonProperty("total_tax")]
        public float TotalTax { get; set; }

        [JsonProperty("total_shipping")]
        public float TotalShipping { get; set; }

        [JsonProperty("cart_tax")]
        public float CartTax { get; set; }

        [JsonProperty("shipping_tax")]
        public float ShippingTax { get; set; }
        
        [JsonProperty("total_discount")]
        public float TotalDiscount { get; set; }

        [JsonProperty("shipping_methods")]
        public string ShippingMethods { get; set; }

        [JsonProperty("payment_details")]
        public PaymentDetails PaymentDetails { get; set; }

        [JsonProperty("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("customer_ip")]
        public string CustomerIp { get; set; }

        [JsonProperty("customer_user_agent")]
        public string CustomerUserAgent { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("view_order_url")]
        public string ViewOrderUrl { get; set; }

        [JsonProperty("line_items")]
        public IEnumerable<LineItem> LineItems { get; set; }

        [JsonProperty("shipping_lines")]
        public IEnumerable<ShippingLine> ShippingLines { get; set; }

        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        [JsonProperty("fee_lines")]
        public IEnumerable<FeeLine> FeeLines { get; set; }

        [JsonProperty("coupon_lines")]
        public IEnumerable<CouponLine> CouponLines { get; set; }


        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }
}

namespace SharpCommerce.Data.Coupons
{
    using Newtonsoft.Json;

    internal class CouponBundle
    {
        [JsonProperty("coupon")]
        public Coupon Content { get; set; }
    }
}

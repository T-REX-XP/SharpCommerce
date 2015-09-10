using System;

namespace SharpCommerce.Data.Coupons
{
    using System.Globalization;

    using Newtonsoft.Json;

    public class Coupon
    {
        private string code;

        private string type;

        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("code")]
        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                this.code = value.ToLower(CultureInfo.InvariantCulture);
            }
        }
        
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                
                switch (value)
                {
                    case "fixed_cart":
                        this.type = value;
                        return;

                    case "percent":
                        this.type = value;
                        return;

                    case "fixed_product":
                        this.type = value;
                        return;

                    case "percent_product":
                        this.type = value;
                        return;

                    default:
                        throw new ArgumentException("Invalid coupon type. Choices are 'fixed_cart', 'percent', 'fixed_product' and 'percent_product'.");
                }
            }
        }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        
        [JsonProperty("amount")]
        public float Amount { get; set; }
        
        [JsonProperty("individual_use")]
        public bool IndividualUse { get; set; }
        
        [JsonProperty("product_ids")]
        public int[] ProductIds { get; set; }
        
        [JsonProperty("exclude_product_ids")]
        public int[] ExcludeProductIds { get; set; }
        
        [JsonProperty("usage_limit")]
        public int? UsageLimit { get; set; }
        
        [JsonProperty("usage_limit_per_user")]
        public int? UsageLimitPerUser { get; set; }
        
        [JsonProperty("limit_usage_to_x_items")]
        public int? LimitUsageToXItems { get; set; }
        
        [JsonProperty("usage_count")]
        public int UsageCount { get; set; }
        
        [JsonProperty("expiry_date")]
        public DateTime? ExpiryDate { get; set; }
        
        [JsonProperty("enable_free_shipping")]
        public bool EnableFreeShipping { get; set; }
        
        [JsonProperty("product_category_ids")]
        public int[] ProductCategoryIds { get; set; }

        [JsonProperty("exclude_product_category_ids")]
        public int[] ExcludeProductCategoryIds { get; set; }
        
        [JsonProperty("exclude_sale_items")]
        public bool ExcludeSaleItems { get; set; }
        
        [JsonProperty("minimum_amount")]
        public float MinimumAmount { get; set; }
        
        [JsonProperty("maximum_amount")]
        public float MaximumAmount { get; set; }
        
        [JsonProperty("customer_emails")]
        public int[] CustomerEmails { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

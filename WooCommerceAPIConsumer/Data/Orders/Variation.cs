namespace SharpCommerce.Data.Orders
{
    using System;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    using SharpCommerce.Data.Downloads;
    using SharpCommerce.Data.Products;

    [DataContract]
    public class Variation
    {
        //////// ????
        [DataMember(Name = "pa_color")]
        public string Color { get; set; }

        [DataMember(Name = "pa_size")]
        public string Size { get; set; }
        ////////


        /// <summary>
        /// Variation ID (post ID) [read-only]
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UTC DateTime when the variation was created [read-only]
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the variation was last updated [read-only]
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// If the variation is downloadable or not. Downloadable variations give access to a file upon purchase
        /// </summary>
        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        /// <summary>
        /// If the variation is virtual or not. Virtual variations are intangible and aren’t shipped
        /// </summary>
        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        /// <summary>
        /// Variation URL (post permalink) [read-only]
        /// </summary>
        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// SKU refers to a Stock-keeping unit, a unique identifier for each distinct product and service that can be purchased
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current variation price. This is setted from regular_price and sale_price [read-only]
        /// </summary>
        [JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>
        /// Variation regular price
        /// </summary>
        [JsonProperty("regular_price")]
        public float RegularPrice { get; set; }

        /// <summary>
        /// Variation sale price
        /// </summary>
        [JsonProperty("sale_price")]
        public float SalePrice { get; set; }

        /// <summary>
        /// Sets the sale start date. Date in the YYYY-MM-DD format [write-only]
        /// </summary>
        [JsonProperty("sale_price_dates_from")]
        public float SalePriceDatesFrom { get; set; }

        /// <summary>
        /// Sets the sale end date. Date in the YYYY-MM-DD format [write-only]
        /// </summary>
        [JsonProperty("sale_price_dates_to")]
        public float SalePriceDatesTo { get; set; }

        /// <summary>
        /// Show if the variation is taxable or not [read-only]
        /// </summary>
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        /// <summary>
        /// Tax status. The options are: taxable, shipping (Shipping only) and none
        /// </summary>
        [JsonProperty("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Tax class
        /// </summary>
        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Enable stock management at variation level
        /// </summary>
        [JsonProperty("managing_stock")]
        public bool ManagingStock { get; set; }

        /// <summary>
        /// Stock quantity. If is a variable variation this value will be used to control stock for all variations, unless you define stock at variation level.
        /// </summary>
        [JsonProperty("stock_quantity")]
        public int StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the variation is listed as “in stock” or “out of stock” on the frontend.
        /// </summary>
        [JsonProperty("in_stock")]
        public bool InStock { get; set; }

        /// <summary>
        /// Shows if a variation is on backorder (if the variation have the stock_quantity negative) [read-only]
        /// </summary>
        [JsonProperty("backordered")]
        public bool BackOrdered { get; set; }

        /// <summary>
        /// Shows if the variation can be bought [read-only]
        /// </summary>
        [JsonProperty("purchaseable")]
        public bool Purchaseable { get; set; }

        /// <summary>
        /// Shows whether or not the product parent is visible in the catalog [read-only]
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// Shows if the variation is on sale or not [read-only]
        /// </summary>
        [JsonProperty("on_sale")]
        public bool OnSale { get; set; }

        /// <summary>
        /// Variation weight in decimal format
        /// </summary>
        [JsonProperty("weight")]
        public float Weight { get; set; }

        /// <summary>
        /// List of the variation dimensions. See Dimensions Properties
        /// </summary>
        [JsonProperty("dimensions")]
        public Dimensions[] Dimensions { get; set; }

        /// <summary>
        /// Shipping class slug. Shipping classes are used by certain shipping methods to group similar products
        /// </summary>
        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        /// <summary>
        /// Shipping class ID [read-only]
        /// </summary>
        [JsonProperty("shipping_class_id")]
        public int ShippingClassId { get; set; }

        /// <summary>
        /// Variation featured image. See Images Properties
        /// </summary>
        [JsonProperty("images")]
        public Image[] Images { get; set; }

        /// <summary>
        /// List of variation attributes. Similar to a simple or variable product, but for variation indicate the attributes used to form the variation. See Attributes Properties
        /// </summary>
        [JsonProperty("attributes")]
        public Products.Attribute[] Attributes { get; set; }

        /// <summary>
        /// List of downloadable files. See Downloads Properties
        /// </summary>
        [JsonProperty("downloads")]
        public DownloadableFile[] Downloads { get; set; }

        /// <summary>
        /// Amount of times the variation can be downloaded. In write-mode you can sent a blank string for unlimited re-downloads. e.g ''
        /// </summary>
        [JsonProperty("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days that the customer has up to be able to download the varition. In write-mode you can sent a blank string for never expiry. e.g ''
        /// </summary>
        [JsonProperty("download_expiry")]
        public int? DownloadExpiry { get; set; }
    }
}

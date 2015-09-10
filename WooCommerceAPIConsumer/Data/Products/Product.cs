using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Products
{
    using System.Net.Mime;

    using Newtonsoft.Json;

    using SharpCommerce.Data.Downloads;
    using SharpCommerce.Data.Orders;

    public class Product
    {
        // Default values for some.
        private string type = "simple";
        private string status = "publish";

        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Product ID (post ID) [read-only]
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UTC DateTime when the product was created [read-only]
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the product was last updated [read-only]
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Product type. By default in WooCommerce the following types are available: simple, grouped, external, variable. Default is simple.
        /// </summary>
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
                    case "simple":
                        this.type = value;
                        return;

                    case "grouped":
                        this.type = value;
                        return;

                    case "external":
                        this.type = value;
                        return;

                    case "variable":
                        this.type = value;
                        return;

                    default:
                        throw new ArgumentException(
                            "Invalid product type. Choices are 'simple', 'grouped', 'external', 'variable'");
                }
            }
        }

        /// <summary>
        /// Product status (post status). Default is 'publish'
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                // TODO
                // need to switch again valid post statuses.
                // need to look those up
                this.status = value;
            }
        }

        /// <summary>
        /// If the product is downloadable or not. Downloadable products give access to a file upon purchase
        /// </summary>
        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        /// <summary>
        /// If the product is virtual or not. Virtual products are intangible and aren’t shipped
        /// </summary>
        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        /// <summary>
        /// Product URL (post permalink) [read-only]
        /// </summary>
        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// SKU refers to a Stock-keeping unit, a unique identifier for each distinct product and service that can be purchased
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current product price. This is setted from regular_price and sale_price [read-only]
        /// </summary>
        [JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>
        /// Product regular price
        /// </summary>
        [JsonProperty("regular_price")]
        public float RegularPrice { get; set; }

        /// <summary>
        /// Product sale price
        /// </summary>
        [JsonProperty("sale_price")]
        public float SalePrice { get; set; }

        /// <summary>
        /// Sets the sale start date. Date in the YYYY-MM-DD format. [write-only]
        /// </summary>
        [JsonProperty("sale_price_dates_from")]
        public DateTime SalePriceDatesFrom { get; set; }

        [JsonProperty("sale_price_dates_to")]
        public DateTime SalePriceDatesTo { get; set; }

        [JsonProperty("price_html")]
        public string PriceHtml { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        private string taxstatus;
        [JsonProperty("tax_status")]
        public string TaxStatus
        {
            get
            {
                return this.taxstatus;
            }
            set
            {
                switch (value)
                {
                    case "taxable":
                        this.type = value;
                        return;

                    case "shipping":
                        this.type = value;
                        return;

                    case "none":
                        this.type = value;
                        return;

                    default:
                        throw new ArgumentException(
                            "Invalid tax status. Choices are 'taxable', 'shipping', 'none'");
                }

            }
        }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("managing_stock")]
        public bool ManagingStock { get; set; }

        [JsonProperty("stock_quantity")]
        public int StockQuantity { get; set; }

        [JsonProperty("in_stock")]
        public bool InStock { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool BackOrdered { get; set; }

        private string backorders;
        [JsonProperty("backorders")]
        public string BackOrders
        {
            get
            {
                return this.backorders;
            }
            set
            {
                switch (value)
                {
                    case "true":
                        this.backorders = value;
                        return;

                    case "false":
                        this.backorders = value;
                        return;

                    case "notify":
                        this.backorders = value;
                        return;

                    default:
                        throw new ArgumentException(
                            "Invalid value. Choices are 'true', 'false', 'notify'");
                }
            }
        }

        [JsonProperty("sold_individually")]
        public bool SoldIndividually { get; set; }

        [JsonProperty("purchaseable")]
        public bool Purchaseable { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        private string catalogvisibility = "visible";

        [JsonProperty("catalog_visibility")]
        public string CatalogVisibility
        {
            get
            {
                return this.catalogvisibility;
            }
            set
            {
                switch (value)
                {
                    case "visible":
                        this.catalogvisibility = value;
                        return;

                    case "catalog":
                        this.catalogvisibility = value;
                        return;

                    case "search":
                        this.catalogvisibility = value;
                        return;

                    case "hidden":
                        this.catalogvisibility = value;
                        return;

                    default:
                        throw new ArgumentException("Invalid value. Choices are 'true', 'false', 'notify'");
                }
            }
        }

        [JsonProperty("on_sale")]
        public bool OnSale { get; set; }

        [JsonProperty("weight")]
        public float? Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("shipping_required")]
        public bool ShippingRequired { get; set; }

        [JsonProperty("shipping_taxable")]
        public bool ShippingTaxable { get; set; }

        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public int ShippingClassId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enable_html_description")]
        public bool EnableHtmlDescription { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("enable_html_short_description")]
        public string EnableHtmlShortDescription { get; set; }

        [JsonProperty("reviews_allowed")]
        public bool ReviewsAllowed { get; set; }

        [JsonProperty("average_rating")]
        public float? AverageRating { get; set; }

        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }

        [JsonProperty("related_ids")]
        public int[] RelatedIds { get; set; }

        [JsonProperty("upsell_ids")]
        public int[] UpsellIds { get; set; }

        [JsonProperty("cross_sell_ids")]
        public int[] CrossSellIds { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }


        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("featured_src")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("attributes")]
        public Products.Attribute[] Attributes { get; set; }

        [JsonProperty("default_attributes")]
        public Products.DefaultAttribute[] DefaultAttributes { get; set; }

        [JsonProperty("downloads")]
        public DownloadableFile[] Downloads { get; set; }

        [JsonProperty("download_limit")]
        public int DownloadLimit { get; set; }


        private string downloadtype = "";
        [JsonProperty("download_type")]
        public string DownloadType
        {
            get
            {
                return this.downloadtype;
            }
            set
            {
                switch (value)
                {
                    case "":
                        this.downloadtype = value;
                        return;

                    case "application":
                        this.downloadtype = value;
                        return;

                    case "music":
                        this.downloadtype = value;
                        return;

                    default:
                        throw new ArgumentException("Invalid value. Choices are '', 'application', 'music'");
                }
            }
        }

        [JsonProperty("purchase_note")]
        public string PuchaseNote { get; set; }

        [JsonProperty("total_sales")]
        public int AmountOfSales { get; set; }

        /// <summary>
        /// List of products variations. 
        /// </summary>
        [JsonProperty("variations")]
        public Variation[] Variations { get; set; }

        /// <summary>
        /// List the product parent data when query for a variation [read-only]
        /// </summary>
        [JsonProperty("parent")]
        public Product[] Parent { get; set; }

        /// <summary>
        /// Product external URL. Only for external products [write-only]
        /// </summary>
        [JsonProperty("product_url")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Product external button text. Only for external products [write-only]
        /// </summary>
        [JsonProperty("button_text")]
        public string ButtonText { get; set; }






        /// /////////////////// ints, vs strings************************************************
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// /////////////////// ints, vs strings************************************************
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        // *******blank string on send**********************************
        [JsonProperty("download_expiry")]
        public int? DownloadExpiry { get; set; }
    }

}
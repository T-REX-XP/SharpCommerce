namespace SharpCommerce
{
    using SharpCommerce.Services;
    using SharpCommerce.Web;

    public class WoocommerceApiClient
    {
        readonly OrderService Orders;
        public readonly CouponService Coupons;
        public readonly CustomerService Customers;
        public readonly ProductService Products;

        public WoocommerceApiClient(string storeUrl, string consumerKey, string consumerSecret)
        {
            var apiDriver = new WoocommerceApiDriver(storeUrl, consumerKey, consumerSecret);

            // this.Index = new IndexService(apiDriver);
            this.Coupons = new CouponService(apiDriver);
            this.Customers = new CustomerService(apiDriver);
            this.Orders = new OrderService(apiDriver);
            this.Products = new ProductService(apiDriver);
            // this.Reports = new ReportsService(apiDriver);
        }
    }
}

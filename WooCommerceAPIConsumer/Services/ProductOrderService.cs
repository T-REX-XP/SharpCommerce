using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Orders;
    using SharpCommerce.Web;

    public class ProductOrderService : Service
    {
        private const string BaseApiEndpoint = "products";

        public ProductOrderService(WoocommerceApiDriver apiDriver)
            : base(apiDriver)
        {
        }


        // View List Of Orders
        public IEnumerable<Order> Get(int productId, Dictionary<string, string> parameters = null)
        {
            return Get<OrdersBundle>(apiEndpoint: String.Format("{0}/{1}/orders", BaseApiEndpoint, productId), parameters: parameters).Content;
        }
    }
}

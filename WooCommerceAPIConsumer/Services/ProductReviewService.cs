using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Products;
    using SharpCommerce.Web;

    public class ProductReviewService : Service
    {
        private const string BaseApiEndpoint = "products";

        public ProductReviewService(WoocommerceApiDriver apiDriver)
            : base(apiDriver)
        {
        }


        // View List Of Orders
        public IEnumerable<ProductReview> Get(int productId, Dictionary<string, string> parameters = null)
        {
            return Get<ProductReviewsBundle>(apiEndpoint: String.Format("{0}/{1}/reviews", BaseApiEndpoint, productId), parameters: parameters).Content;
        }
    }
}

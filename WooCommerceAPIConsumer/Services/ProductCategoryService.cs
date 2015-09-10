using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Products;
    using SharpCommerce.Web;

    public class ProductCategoryService : Service
    {
        private const string BaseApiEndpoint = "products/categories";

        public ProductCategoryService(WoocommerceApiDriver apiDriver)
            : base(apiDriver) { }

        // View a Product Category
        public ProductCategory Get(int productCategoryId)
        {
            return this.Get<ProductCategoryBundle>(apiEndpoint: String.Format("{0}/{1}", BaseApiEndpoint, productCategoryId)).Content;
        }

        // View a List of Product Categories
        public IEnumerable<ProductCategory> Get(Dictionary<string, string> parameters = null)
        {
            return Get<ProductCategoriesBundle>(apiEndpoint: BaseApiEndpoint, parameters: parameters).Content;
        }


    }
}

using System;
using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Products;
    using SharpCommerce.Web;

    public class ProductService : Service
    {
        public readonly ProductAttributeService Attributes;
        public readonly ProductCategoryService Categories;
        public readonly ProductOrderService Orders;
        public readonly ProductReviewService Reviews;

        public ProductService(WoocommerceApiDriver apiDriver)
            : base(apiDriver)
        {
            Attributes = new ProductAttributeService(apiDriver);
            Categories = new ProductCategoryService(apiDriver);
            Orders = new ProductOrderService(apiDriver);
            Reviews = new ProductReviewService(apiDriver);
        }

        // Create a Product
        public Product Create(Product productData)
        {
            return Post(apiEndpoint: "products", toSerialize: new ProductBundle { Content = productData }).Content;
        }


        // View a Product
        public Product Get(int productId)
        {
            return this.Get<ProductBundle>(apiEndpoint: String.Format("products/{0}", productId)).Content;
        }

        // View List of Products
        public IEnumerable<Product> Get(Dictionary<string, string> parameters = null)
        {
            return Get<ProductsBundle>(apiEndpoint: "products", parameters: parameters).Content;
        }

        // Update a Product
        public Product Update(int productId, Product newData)
        {
            return Put(apiEndpoint: String.Format("products/{0}", productId), toSerialize: new ProductBundle { Content = newData }).Content;
        }

        // Create/Update Multiple Products
        public IEnumerable<Product> CreateUpdateMany(IEnumerable<Product> ordersData)
        {
            return Put(apiEndpoint: "products/bulk", toSerialize: new ProductsBundle { Content = ordersData }).Content;
        }

        // Delete a Product
        public string MoveToTrash(int id)
        {
            return Delete(id);
        }

        // Delete a Product Permanently
        public string DeletePermanently(int id)
        {
            return Delete(id, force: true);
        }

        private string Delete(int id, bool force = false)
        {
            var apiEndpoint = String.Format("products/{0}", id);
            var parameters = new Dictionary<string, string> { { "force", force.ToString().ToLower() } };
            return Delete<dynamic>(apiEndpoint, parameters).message;
        }

        // View Products Count
        public int Count(Dictionary<string, string> parameters = null)
        {
            return Get<dynamic>(apiEndpoint: "products/count", parameters: parameters).count;
        }
    }
}

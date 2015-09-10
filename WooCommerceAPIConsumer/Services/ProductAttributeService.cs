using System;
using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Products;
    using SharpCommerce.Web;

    public class ProductAttributeService : Service
    {
        private const string BaseApiEndpoint = "products/attributes";

        public ProductAttributeService(WoocommerceApiDriver apiDriver)
            : base(apiDriver) { }

        // Create a Product Attribute
        public ProductAttribute Create(ProductAttribute productAttributeData)
        {
            return Post(apiEndpoint: BaseApiEndpoint, toSerialize: new ProductAttributeBundle { Content = productAttributeData }).Content;
        }

        // View a Product Attribute
        public ProductAttribute Get(int productAttributeId)
        {
            return this.Get<ProductAttributeBundle>(apiEndpoint: String.Format("{0}/{1}", BaseApiEndpoint, productAttributeId)).Content;
        }

        // View a List of Product Attribute
        public IEnumerable<ProductAttribute> Get(Dictionary<string, string> parameters = null)
        {
            return Get<ProductAttributesBundle>(apiEndpoint: BaseApiEndpoint, parameters: parameters).Content;
        }

        // Update a Product Attribute
        public ProductAttribute Update(int productAttributeId, ProductAttribute newData)
        {
            return Put(apiEndpoint: String.Format("{0}/{1}", BaseApiEndpoint, productAttributeId), toSerialize: new ProductAttributeBundle { Content = newData }).Content;
        }

        // Delete a Product Attribute
        public string MoveToTrash(int id)
        {
            return Delete(id);
        }

        // Delete a Product Attribute Permanently
        public string DeletePermanently(int id)
        {
            return Delete(id, force: true);
        }

        private string Delete(int id, bool force = false)
        {
            var apiEndpoint = String.Format("{0}/{1}", BaseApiEndpoint, id);
            var parameters = new Dictionary<string, string> { { "force", force.ToString().ToLower() } };
            return Delete<dynamic>(apiEndpoint, parameters).message;
        }
    }
}

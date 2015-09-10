using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Services
{
    using SharpCommerce.Data.Customers;
    using SharpCommerce.Data.Downloads;
    using SharpCommerce.Data.Orders;
    using SharpCommerce.Web;

    public class CustomerService : Service
    {
        public CustomerService(WoocommerceApiDriver apiDriver)
            : base(apiDriver) { }

        // Create A Customer
        public Customer Create(Customer orderData)
        {
            return Post(apiEndpoint: "customers", toSerialize: new CustomerBundle { Content = orderData }).Content;
        }

        // View A Customer by id
        public Customer Get(int customerId)
        {
            return this.Get<CustomerBundle>(apiEndpoint: String.Format("customers/{0}", customerId)).Content;
        }

        // View A Customer by Email
        public Customer Get(string email)
        {
            return this.Get<CustomerBundle>(apiEndpoint: String.Format("customers/email/{0}", email)).Content;
        }

        // View List Of Customers
        public IEnumerable<Customer> Get(Dictionary<string, string> parameters = null)
        {
            return Get<CustomersBundle>(apiEndpoint: "customers", parameters: parameters).Content;
        }

        // Update A Customer
        public Customer Update(int customerId, Customer newData)
        {
            return Put(apiEndpoint: String.Format("customers/{0}", customerId), toSerialize: new CustomerBundle { Content = newData }).Content;
        }

        // Create/Update Multiple Customers
        public IEnumerable<Customer> CreateUpdateMany(IEnumerable<Customer> ordersData)
        {
            return Put(apiEndpoint: "customers/bulk", toSerialize: new CustomersBundle { Content = ordersData }).Content;
        }

        // Delete a Customer Permanently
        public string DeletePermanently(int id)
        {
            return Delete<dynamic>(apiEndpoint: String.Format("customers/{0}", id)).message;
        }

        // View Customers Count
        // Can have the 'role' filter for customers vs subscribers
        public int Count(Dictionary<string, string> parameters = null)
        {
            return Get<dynamic>(apiEndpoint: "customers/count", parameters: parameters).count;
        }

        // View Customer Orders
        public IEnumerable<Order> GetOrders(int customerId, Dictionary<string, string> parameters = null)
        {
            return Get<OrdersBundle>(apiEndpoint: String.Format("customers/{0}/orders", customerId), parameters: parameters).Content;
        }

        // View Customer Downloads
        public IEnumerable<Download> GetDownloads(int customerId, Dictionary<string, string> parameters = null)
        {
            return Get<DownloadsBundle>(apiEndpoint: String.Format("customers/{0}/downloads", customerId), parameters: parameters).Content;
        }
    }
}

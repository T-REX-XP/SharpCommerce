using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using System;
    using SharpCommerce.Data.Orders;
    using SharpCommerce.Web;

    public class OrderService : Service
    {
        public readonly OrderNotesService Notes;
        public readonly OrderRefundsService Refunds;

        public OrderService(WoocommerceApiDriver apiDriver)
            : base(apiDriver)
        {
            Notes   = new OrderNotesService(apiDriver);
            Refunds = new OrderRefundsService(apiDriver);
        }

        // Create An Order
        public Order Create(Order orderData)
        {
            return Post(apiEndpoint: "orders", toSerialize: new OrderBundle { Content = orderData }).Content;
        }

        // View An Order
        public Order Get(int orderId)
        {
            return this.Get<OrderBundle>(apiEndpoint: String.Format("orders/{0}", orderId)).Content;
        }

        // View List Of Orders
        public IEnumerable<Order> Get(Dictionary<string, string> parameters = null)
        {
            return Get<OrdersBundle>(apiEndpoint: "orders", parameters: parameters).Content;
        }
        
        // Create/Update Multiple Orders
        public IEnumerable<Order> CreateUpdateMany(IEnumerable<Order> ordersData)
        {
            return Put(apiEndpoint: "orders/bulk", toSerialize: new OrdersBundle { Content = ordersData }).Content;
        }

        // Update An Order
        public Order Update(int orderId, Order newData)
        {
            return Put(apiEndpoint: String.Format("orders/{0}", orderId), toSerialize: new OrderBundle { Content = newData }).Content;
        }

        // Delete an Order
        public string MoveToTrash(int id)
        {
            return Delete(id);
        }

        // Delete an Order Permanently
        public string DeletePermanently(int id)
        {
            return Delete(id, force: true);
        }

        // View Orders Count
        public int Count(Dictionary<string, string> parameters = null)
        {
            return Get<dynamic>(apiEndpoint: "orders/count", parameters: parameters).count; 
        }

        // View List of Order Statuses 
        public OrderStatuses GetStatuses()
        {
            return Get<OrderStatusesBundle>(apiEndpoint: "orders/statuses").Content;
        }
        
        private string Delete(int id, bool force = false)
        {
            var apiEndpoint = String.Format("orders/{0}", id);
            var parameters = new Dictionary<string, string> { { "force", force.ToString().ToLower() } };
            return Delete<dynamic>(apiEndpoint, parameters).message;
        }
    }
}

using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using System;
    using SharpCommerce.Data.Orders;
    using SharpCommerce.Web;

    public class OrderRefundsService : Service
    {
        public OrderRefundsService(WoocommerceApiDriver apiDriver) : base(apiDriver) { }

        // Create A Refund For An Order
        public OrderRefund Create(int orderId, OrderRefund newData)
        {
            return Post(apiEndpoint: String.Format("orders/{0}/refunds", orderId), toSerialize: new OrderRefundBundle() { Content = newData }).Content;
        }

        // View An Order Note
        public OrderRefund Get(int orderId, int refundId)
        {
            return Get<OrderRefundBundle>(apiEndpoint: String.Format("orders/{0}/refunds/{1}", orderId, refundId)).Content;
        }

        // View List of Refunds From An Order
        public IEnumerable<OrderRefund> Get(int orderId)
        {
            return this.Get<OrderRefundsBundle>(apiEndpoint: String.Format("orders/{0}/refunds", orderId)).Content;
        }

        // Update An Order Refund
        public OrderRefund Update(int orderId, int refundId, OrderRefund newData)
        {
            return Put(apiEndpoint: String.Format("orders/{0}/refunds/{1}", orderId, refundId), toSerialize: new OrderRefundBundle { Content = newData }).Content;
        }

        // Delete An Order Refund
        public string Delete(int orderId, int refundId)
        {
            return Delete<dynamic>(apiEndpoint: String.Format("orders/{0}/refunds/{1}", orderId, refundId)).message;
        }
    }
}

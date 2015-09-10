using System.Collections.Generic;

namespace SharpCommerce.Services
{
    using System;
    using SharpCommerce.Data.Orders;
    using SharpCommerce.Web;

    public class OrderNotesService : Service
    {
        public OrderNotesService(WoocommerceApiDriver apiDriver) : base(apiDriver) { }

        // Create A Note For An Order
        public OrderNote Create(int orderId, OrderNote newData)
        {
            return Post(apiEndpoint: String.Format("orders/{0}/notes", orderId), toSerialize: new OrderNoteBundle { Content = newData }).Content;
        }

        // View An Order Note
        public OrderNote Get(int orderId, int noteId)
        {
            return Get<OrderNoteBundle>(apiEndpoint: String.Format("orders/{0}/notes/{1}", orderId, noteId)).Content;
        }

        // View List Of Notes From An Order
        public IEnumerable<OrderNote> Get(int orderId)
        {
            return this.Get<OrderNotesBundle>(apiEndpoint: String.Format("orders/{0}/notes", orderId)).Content;
        }

        // Update An Order Note
        public OrderNote Update(int orderId, int noteId, OrderNote newData)
        {
            return Put(apiEndpoint: String.Format("orders/{0}/notes/{1}", orderId, noteId), toSerialize: new OrderNoteBundle { Content = newData }).Content;
        }

        // Delete An Order Note
        public string Delete(int orderId, int noteId)
        {
            return Delete<dynamic>(apiEndpoint: String.Format("orders/{0}/notes/{1}", orderId, noteId)).message;
        }
    }
}

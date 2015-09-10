using System;

namespace WooCommerceAPIClient
{
    using SharpCommerce;
    using SharpCommerce.Data.Customers;
    using SharpCommerce.Data.Orders;
    using System.Collections.Generic;

    using SharpCommerce.Services;

  
    class Program
    {
        static void Main(string[] args)
        {
            const string StoreUrl = "http://leonvalleyflowers.net";
            const string ConsumerKey = "ck_67a9f46c3ecc6986f4859871cef93958bbabe0ce";
            const string ConsumerSecret = "cs_dea5e153b32f7905e1e7adc323ff15d3ba8e5b78";

            var api = new WoocommerceApiClient(StoreUrl, ConsumerKey, ConsumerSecret);
            var parameters = new Dictionary<string, string>();




            // ORDERS /////////////////////////////////////////

            // View All Orders
            // Only returns last 4?
            // set limit to override default page size
            //api.Parameters.AddFilterLimit(200);
            //var vaoresult = api.Orders.Get(parameters);

            // View All Orders of a Given Status
            // Only returning 4
            // parameters.AddFilterLimit(30);
            // parameters.AddFilterStatus("cancelled");
            // var vaogsresult = api.Orders.Get(parameters);


            // Update An Order
            //var uaoresult = api.Orders.Update(3056, new Order { BillingAddress = new BillingAddress { FirstName = "jjj" }});

            // Update/Create Many
            // If valid id given, update. else, create.
            //var ucmresult = api.Orders.CreateUpdateMany(new List<Order>
            //{
            //    new Order { Id = 3030, BillingAddress = new BillingAddress { FirstName = "ddd" }},
            //    new Order { Id = 3028, BillingAddress = new BillingAddress { FirstName = "eee" }},
            //    new Order { Id = 3025, BillingAddress = new BillingAddress { FirstName = "fff" }},
            //    new Order { BillingAddress = new BillingAddress { FirstName = "ggg" }},
            //});

            // Delete an order Permanently
            // var resultMessagePerm = api.Orders.DeletePermanently(3134); // Permanently Deleted Order

            // Delete An Order (move to Trash)
            //var resultMessage = api.Orders.MoveToTrash(3031);

            // View Orders Count by Status
            //var ordersCountCancelled = api.Orders.Count(OrderStatus.Cancelled);

            // View Orders Count
            //var ordersCountAll = api.Orders.Count();

            // View List Of Order Statuses
            //var vloos = api.Orders.GetStatuses();

            // ORDER NOTES //////////

            
            // View An Order Note
            //var dResult = api.Orders.Notes.Get(3028, 656);
            //var text = new ReadOnlyClass { Id = 2 };

            // Create A Note For An Order
            // var vaonResult = api.Orders.Notes.Create(3030, new OrderNote { Note = "This is a new note1!" });

            // Update An Order Note
            // var uResult = api.Orders.Notes.Update(3030, 1566, new OrderNote { Note = "This is the updated note." });

            // Delete An Order Note
            // var dResult = api.Orders.Notes.Delete(3030, 1567);

            // View List Of Notes From An Order
            // var vlonResult = api.Orders.Notes.Get(3028);


            // COUPONS
            //parameters.AddFilterLimit(30);
            //var gcsResult = api.Coupons.Get(parameters);

        }
    }
}
namespace SharpCommerce.Data.Orders
{
    internal class OrderStatusFilter
    {
        internal const string Key = "filter[status]";

        internal string Value
        {
            get
            {
                return this.value;
            }
        }

        private readonly string value;

        public OrderStatusFilter(OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Pending:
                    this.value = "pending";
                    break;

                case OrderStatus.Processing:
                    this.value = "processing";
                    break;

                case OrderStatus.OnHold:
                    this.value = "on-hold";
                    break;

                case OrderStatus.Completed:
                    this.value = "completed";
                    break;

                case OrderStatus.Cancelled:
                    this.value = "cancelled";
                    break;

                case OrderStatus.Refunded:
                    this.value = "refunded";
                    break;

                case OrderStatus.Failed:
                    this.value = "failed";
                    break;
            }
        }

    }
}

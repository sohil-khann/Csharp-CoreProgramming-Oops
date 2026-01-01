using System;

namespace MultilevelInheritance
{
    // Base class Order
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(string orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    // Subclass ShippedOrder extending Order
    public class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber) 
            : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return $"Order Shipped (Tracking: {TrackingNumber})";
        }
    }

    // Subclass DeliveredOrder extending ShippedOrder
    public class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) 
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return $"Order Delivered on {DeliveryDate.ToShortDateString()} (Tracking: {TrackingNumber})";
        }
    }
}

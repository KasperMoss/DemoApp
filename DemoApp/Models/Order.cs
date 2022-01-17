using System;

namespace DemoApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int NumberOfItems { get; set; }
        public DateTime Ordered { get; set; }
        public DateTime Delivered { get; set; }
        public int CustomerId {get; set;}
    }

    public enum OrderStatus
    {
        Pending,
        Delivered
    }
}

using DemoApp.Models;
using System.Linq;

namespace DemoApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer {Name = "Peter"},
                new Customer {Name = "Joan"},
                new Customer {Name = "Anders"},
                new Customer {Name = "Senol"},
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order {CustomerId = 1, Cost = 10, Ordered = new System.DateTime(2022,01,10), NumberOfItems = 3},
                new Order {CustomerId = 2, Cost = 20, Ordered = new System.DateTime(2022,01,7), NumberOfItems = 3},
                new Order {CustomerId = 1, Cost = 10, Ordered = new System.DateTime(2022,01,15), NumberOfItems = 3},

            };
            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();
        }
    }
}

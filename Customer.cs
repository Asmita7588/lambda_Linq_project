using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LambdaLinqProject
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

     class CusOrder
     {
        public void CustomerList()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Ankita" },
                new Customer { Id = 2, Name = "Asmita" },
                new Customer { Id = 3, Name = "Chetan" },
                new Customer { Id = 4, Name = "Bhumesh" }
            };

            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 101, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-10) },
                new Order { OrderId = 102, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-5) },
                new Order { OrderId = 103, CustomerId = 3, OrderDate = DateTime.Now.AddDays(-40) },
                new Order { OrderId = 104, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-15) }
            };

            DateTime orderWithinThirtynDays = DateTime.Now.AddDays(-30);

            var recentCustomer = customers.
            Where(c => orders.Any(o => o.CustomerId == c.Id && o.OrderDate >= orderWithinThirtynDays))
            .ToList();

            Console.WriteLine("Customers who placed orders in the last 30 days:");
            foreach (var customer in recentCustomer)
            {
                Console.WriteLine(customer.Name);
            }

        }   
        
        public void FindLargestOrders()
        {
            List<Order> orders = new List<Order>
            {
            new Order { OrderId = 1, OrderDate = new DateTime(2024, 2, 10), TotalAmount = 12000 },
            new Order { OrderId = 2, OrderDate = new DateTime(2024, 1, 15), TotalAmount = 9500 },
            new Order { OrderId = 3, OrderDate = new DateTime(2024, 2, 5), TotalAmount = 15000 },
            new Order { OrderId = 4, OrderDate = new DateTime(2024, 1, 20), TotalAmount = 7000 },
            new Order { OrderId = 5, OrderDate = new DateTime(2024, 2, 1), TotalAmount = 18000 }
            };

            var filterOrders = orders.Where(order => order.TotalAmount > 10000)
                .GroupBy(order => order.OrderDate)
                .ToList();

            Console.WriteLine("Orders with Total Amount > $10,000 (Sorted by Date):");
            foreach (var order in filterOrders)
            {
                Console.WriteLine(order.Key);

            }
        }
     }
    
}

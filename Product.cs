using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }

    class  ProductDetails
    {
        public void OutOfStockProduct() { 

            List<Product> productList = new List<Product>
           {
            new Product { Name = "Laptop", Stock = 5 },
            new Product { Name = "Phone", Stock = 0 },
            new Product { Name = "Tablet", Stock = 2 },
            new Product { Name = "Smartwatch", Stock = 0 },
            new Product { Name = "Headphones", Stock = 7 }
           };

            var outOfStockProducts = productList
                .Where(p => p.Stock == 0)
                .Select(p => p.Name)
                .ToList();

            Console.WriteLine("Out of stock products:");
            Console.WriteLine(string.Join(", ", outOfStockProducts));
        }
    }
}

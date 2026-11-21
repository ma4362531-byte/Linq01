using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq01
{
    public static class ListGenerators
    {
        public static List<Product> ProductList { get; set; } = new()
    {
        new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
        new Product { ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
        new Product { ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
        new Product { ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
        new Product { ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35m, UnitsInStock = 0 },
        new Product { ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 },
        new Product { ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00m, UnitsInStock = 24 },
        new Product { ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50m, UnitsInStock = 42 }
    };

        public static List<Customer> Customers { get; set; } = new()
    {
        new Customer
        {
            CustomerID = "ALFKI",
            CustomerName = "Alfreds Futterkiste",
            Orders = new()
            {
                new Order { OrderDate = new DateTime(1996, 7, 4), Total = 250m },
                new Order { OrderDate = new DateTime(1997, 8, 25), Total = 500m }
            }
        },
        new Customer
        {
            CustomerID = "ANATR",
            CustomerName = "Ana Trujillo Emparedados",
            Orders = new()
            {
                new Order { OrderDate = new DateTime(1998, 2, 18), Total = 320m }
            }
        }
    };
    }
}

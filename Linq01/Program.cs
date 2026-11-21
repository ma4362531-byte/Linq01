namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // 1. Get all products from the "Seafood" category. Print each product's name and price.

            //var q1 = ListGenerators.ProductList.Where(p => p.Category == "Seafood");
            //foreach (var p in q1)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}


            #endregion

            #region Q2

            // 2. Get a list of only the product names from ProductList. Print each name.

            //var q2 = ListGenerators.ProductList.Select(p => p.ProductName).ToList();
            //foreach (var name in q2)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Q3

            // 3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var q3 = ListGenerators.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var p in q3)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region Q4

            // 4. Get all products where UnitPrice is between 10 and 30

            //var q4 = ListGenerators.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in q4)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q5

            // 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var q5 = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var p in q5)
            //{
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //}
            #endregion

            #region Q6

            // 6. Create a new anonymous type with three properties:
            // ● Name → the product name
            // ● Price → the unit price
            // ● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            // ● Print the result.

            //var q6 = ListGenerators.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in q6)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            //}
            #endregion

            #region Q7

            // 7. Print each product's name along with its position (1-based) in the list. Expected format: 1. Chai, 2. Chang, etc.

            //var q7 = ListGenerators.ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");
            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8

            // 8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var q8 = ListGenerators.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var p in q8)
            //{
            //    Console.WriteLine($"{p.Category} | {p.ProductName} | {p.UnitPrice}");
            //}
            #endregion




        }
    }
}

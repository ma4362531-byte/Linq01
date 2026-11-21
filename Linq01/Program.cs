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




        }
    }
}

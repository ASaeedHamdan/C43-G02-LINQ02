using Linq_Assgiment02.Data;
using static Linq_Assgiment02.ListGenerator;

namespace Linq_Assgiment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Setup Test
            //Console.WriteLine(ProductsList[0]);

            //Console.WriteLine(CustomersList[0]);
            #endregion
            #region Aggregate Operators
            #region Q1
            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                          .GroupBy(p => p.Category)
            //                         .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //var result = ProductsList.GroupBy(p => p.Category)
            //                                  .Select(g => new { Category = g.Key, Cheap_Price = g.Min(p => p.UnitPrice) });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #region Q3

            //var result = from p in ProductsList
            //             group p by p.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 CheapestProducts = g.Where(p => p.UnitPrice == minPrice)
            //             };
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");

            //    foreach (var product in group.CheapestProducts)
            //    {
            //        Console.WriteLine($"                  Product Name: {product.ProductName}, Price: {product.UnitPrice}");
            //    }

            //}
            #endregion
            #region Q4
            //var result = ProductsList.GroupBy(p => p.Category)
            //                            .Select(g => new { Category = g.Key, Most_Expensive_Price = g.Max(p => p.UnitPrice) });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q5
            //var result = from p in ProductsList
            //             group p by p.Category into g
            //             let maxPrice = g.Max(p => p.UnitPrice)
            //             select new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == maxPrice) };


            //foreach (var Category in result)
            //{
            //    Console.WriteLine($"Category: {Category.Category}");

            //    foreach (var product in Category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"                  Product Name: {product.ProductName}, Price: {product.UnitPrice}");
            //    }

            //}


            #endregion

            #region Q6
            //var result = ProductsList
            //                    .GroupBy(p => p.Category)
            //                    .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Set Operators

            #region Q1
            //var UniqueCatNames = ProductsList.Select(P => P.Category).Distinct();
            //foreach (var item in UniqueCatNames)
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            //var ConcatSequences = ProductsList.Select(P => P.ProductName[0])
            //    .Concat(CustomersList.Select(C => C.CustomerName[0])).Distinct();
            //foreach (var item in ConcatSequences)
            //    Console.WriteLine(item);
            #endregion

            #region Q3
            //var CommonSequences = ProductsList.Select(P => P.ProductName[0])
            //    .Intersect(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var item in CommonSequences)
            //    Console.WriteLine(item);
            #endregion

            #region Q4
            //var ExceptSequences = ProductsList.Select(P => P.ProductName[0])
            //    .Except(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var item in ExceptSequences)
            //    Console.WriteLine(item);
            #endregion

            #region Q5
            //var result = ProductsList.Select(p => new string(p.ProductName.TakeLast(3).ToArray()))
            //            .Concat(CustomersList.Select(c => new string(c.CustomerName.TakeLast(3).ToArray())));
            //    foreach (var item in result)
            //    Console.Write($"{item} , ");
            #endregion
            #endregion

            #region Partitioning Operators
            #region Q1
            //var result = CustomersList.Where(c => c.Region == "WA")
            //                          .SelectMany(c => c.Orders)
            //                           .Take(3);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            //var result = CustomersList.Where(c => c.Region == "WA")
            //                         .SelectMany(c => c.Orders)
            //                          .Skip(2);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((N, I) => N >= I);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion
            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n,i)=> n > i);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion





            #endregion

            #region Quantifiers Operators

            #region Q1
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);

            #endregion
            #region Q2
            //var result = ProductsList.GroupBy(p => p.Category)
            //                         .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                         .Select(g => new { Category = g.Key, Products = g });

            //foreach (var cat in result)
            //  {
            //    foreach (var item in cat.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region Q3
            //var result = ProductsList.GroupBy(p => p.Category)
            //                       .Where(g => g.All(p => p.UnitsInStock > 0))
            //                       .Select(g => new { Category = g.Key, Products = g });

            //foreach (var cat in result)
            //{
            //    foreach (var item in cat.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #endregion

            #region Grouping Operators

            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"numbers with a reminder of {group.Key} when divided by 5 : ");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            #endregion
            #region Q2
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.GroupBy(word => word[0]);
            //foreach (var word in result)
            // Console.WriteLine($" {word.Key}  ");

            #endregion
            #region Q3
            //string[] arr = { "from", "salt", "earn", "last", "near", "form" };
           
            //var result = arr.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));
            //foreach (var group in result)
            //{
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
                  
            //    }
            //    if (group.Count() > 1)
            //    {
            //        Console.WriteLine("....");
            //    }
            //}
            #endregion
            #endregion



        }


    }
}

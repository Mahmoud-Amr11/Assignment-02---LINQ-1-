using ASSLINQ;
using System.Net.WebSockets;

namespace Assignment_02___LINQ__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = ListGenerators.ProductList;
            var customers = ListGenerators.CustomerList;
            string[] words = File.ReadAllLines("dictionary_english.txt");

            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.

            //var result = products.Where(p => p.UnitsInStock == 0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ToString());
            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ToString());
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Select((name, value) => new { Name = name, Value = value })
            //  .Where(x => x.Name.Length < x.Value)
            //  .Select(x => x.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion


            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 

            //var result = products.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result.ToString());
            #endregion


            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            //var result = products.FirstOrDefault(p => p.UnitPrice > 1000,null);
            //Console.WriteLine(result);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr
            //    .Where(x => x > 5)
            //    .Skip(1)
            //    .FirstOrDefault();

            //Console.WriteLine(result);
            #endregion



            #endregion


            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(x => x % 2 != 0);
            //Console.WriteLine(result);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var result = customers.Select(c => new { c.CustomerName, OrderCount = c.Orders.Length });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerName} - {item.OrderCount} orders");
            //}
            #endregion



            #region 3. Return a list of categories and how many products each has

            //var result = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, ProductCount = g.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductCount} products");
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result= words.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters = {result}");
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word = {result}");
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = words.Max(w => w.Length);
            //Console.WriteLine($"Length of the longest word = {result}");
            #endregion


            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            // var reselt = words.Average(word => word.Length);
            //Console.WriteLine($"Average length of the words = {reselt}");
            #endregion


            #region 9. Get the total units in stock for each product category.

            //var result = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - Total Units in Stock: {item.TotalUnitsInStock}");
            //}

            #endregion


            #region 10. Get the cheapest price among each category's products

            //var result = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - Cheapest Price: {item.CheapestPrice:C}");
            //}

            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsByCategory =
            //from p in products
            //group p by p.Category into g
            //let minPrice = g.Min(x => x.UnitPrice)
            //from prod in g
            //where prod.UnitPrice == minPrice
            //select new
            //{
            //    Category = g.Key,
            //    ProductName = prod.ProductName,
            //    Price = prod.UnitPrice
            //};

            //foreach (var item in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.Price}");
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //  var mostExpensiveByCategory = products
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(x => x.UnitPrice))
            //});

            //foreach (var category in mostExpensiveByCategory)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"   {product.ProductName} - {product.UnitPrice}");
            //    }
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //var result = products.
            //   GroupBy(p => p.Category)
            //   .Select(g => new
            //   {
            //       Category = g.Key,
            //       MostExpensiveProduct = g.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
            //   });
            //   foreach (var item in result)
            //   {
            //       if (item.MostExpensiveProduct != null)
            //       {
            //           Console.WriteLine($"{item.Category} - {item.MostExpensiveProduct.ProductName} - {item.MostExpensiveProduct.UnitPrice:C}");
            //       }
            //   }

            #endregion


            #region 14. Get the average price of each category's products.

            //var result = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - Average Price: {item.AveragePrice:C}");
            //}
            #endregion


            #endregion



            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var resutl = products
            //    .Select(p => p.Category)
            //    .Distinct();
            //foreach (var category in resutl)
            //    {
            //    Console.WriteLine(category);
            //}
            #endregion


            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = products
            //.Select(p => p.ProductName[0])           
            //.Union(customers.Select(c => c.CustomerName[0])) 
            //.Distinct();                          

            //foreach (var letter in result)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion


            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            // var result = products
            //.Select(p => p.ProductName[0])          
            //.Intersect(customers.Select(c => c.CustomerName[0]))
            //.Distinct();                               

            //foreach (var letter in result)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion


            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = products
            //.Select(p => char.ToUpper(p.ProductName[0]))  
            //.Distinct()
            //.Except(customers
            //    .Select(c => char.ToUpper(c.CustomerName[0]))
            //    .Distinct());


            //foreach (var letter in result)
            //    Console.WriteLine(letter);
            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = products
            //.Select(p => p.ProductName.Length >= 3
            //    ? p.ProductName.Substring(p.ProductName.Length - 3)
            //    : p.ProductName)
            //.Concat(customers
            //.Select(c => c.CustomerName.Length >= 3
            //    ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //    : c.CustomerName));


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion




            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var result = customers
            //    .Where(c => c.Region == "WA")       
            //    .SelectMany(c => c.Orders)          
            //    .Take(3);
            //foreach (var order in result)
            //    {
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = customers
            //.Where(c => c.Region == "WA")   
            //.SelectMany(c => c.Orders)      
            //.Skip(2)                        
            //.ToList();

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}


            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //.TakeWhile((n, index) => n >= index) 
            //.ToArray();

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //.SkipWhile(n => n % 3 != 0) 
            //.ToArray();


            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //.SkipWhile((n, index) => n >= index) 
            //.ToArray();

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #endregion



            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //bool hasEi = words.Any(w => w.Contains("ei", StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine(hasEi  ? "There is at least one word containing 'ei'."  : "No words contain 'ei'.");

            #endregion



            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var result = products
            .GroupBy(p => p.Category)                      
            .Where(g => g.Any(p => p.UnitsInStock == 0))    
            .ToList();


            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
                }
            }

            #endregion

            #endregion




        }
    }
}

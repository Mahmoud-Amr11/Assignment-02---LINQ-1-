using ASSLINQ;

namespace Assignment_02___LINQ__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = ListGenerators.ProductList;
            var customers = ListGenerators.CustomerList;


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

            var result = customers.Select(c => new { c.CustomerName, OrderCount = c.Orders.Length });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.CustomerName} - {item.OrderCount} orders");
            }
            #endregion



            #endregion




        }
    }
}

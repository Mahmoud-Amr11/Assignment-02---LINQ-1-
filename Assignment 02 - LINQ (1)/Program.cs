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

            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = Arr.Select((name, value) => new { Name = name, Value = value })
              .Where(x => x.Name.Length < x.Value)
              .Select(x => x.Name);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            #endregion

            #endregion




        }
    }
}

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

            var result = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            foreach (var product in result)
            {
                Console.WriteLine(product.ToString());
            }

            #endregion

            #endregion




        }
    }
}

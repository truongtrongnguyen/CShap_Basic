using System;
using System.Collections.Generic;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting : ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Ascending Order
            //Using Method Syntax
            var MS = intList.OrderBy(num => num);
            //Using Query Syntax
            var QS = (from num in intList
                      orderby num
                      select num).ToList();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 < 7).ToList();
        }
    }
}

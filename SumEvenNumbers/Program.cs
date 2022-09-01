using System;
using System.Collections.Generic;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(SumEvenNumbers(A));
        }

        //public static int SumEvenNumbers(int[] input)
        //{
        //    int result = 0;

        //    foreach (var item in input)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //Using LINQ
        public static int SumEvenNumbers(int[] input)
        {
            return input.Where(p => p % 2 == 0).Sum();
            //return input.Where(p => p % 2 == 0).Sum(e => (long)e);
        }
    }
}

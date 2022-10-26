using System;

namespace CompareTimeNull
{
    class Program
    {
        static DateTime time; // value type
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.0;

            //type coercion
            Console.WriteLine(time == null); // Expected: false
            Console.WriteLine(x == y); // Expected: true
        }
    }
}

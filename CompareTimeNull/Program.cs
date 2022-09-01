using System;

namespace CompareTimeNull
{
    class Program
    {
        static DateTime time;
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.0;

            //type coercion
            Console.WriteLine(time == null); // true or false?
            Console.WriteLine(x == y); // true or false?
        }
    }
}

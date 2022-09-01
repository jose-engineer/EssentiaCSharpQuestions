using System;

namespace KilometersToMeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in kilometers to convert:");
            int km = Convert.ToInt32(Console.ReadLine());

            long mts = km * 1000;

            Console.WriteLine("The distance on meters is: {0} mts.", mts);

            Console.ReadLine();
        }
    }
}

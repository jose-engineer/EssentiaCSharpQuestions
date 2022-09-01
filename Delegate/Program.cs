using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        delegate void Printer();
        static void Main(string[] args)
        {
            List<Printer> printers = new List<Printer>();

            int i = 0;

            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); }); //The delegate is added in the for loop and “pointer”/"reference" to i is stored, rather than the value itself. 
            }
            //After we exit the loop, the variable i has been set to 10.
            foreach (var item in printers)
            {
                item(); //By the time each delegate is invoked, the value passed to all of them is 10.
            }
        }
    }
}

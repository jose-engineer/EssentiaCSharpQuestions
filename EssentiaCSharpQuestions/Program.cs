using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeValueType
{
    class Program
    {
        static string location; // string is a reference type, classes are reference types
        static DateTime time; // DateTime is a value type, structs are value types

        static void Main(string[] args)
        {    

            Console.WriteLine(location == null ? "location is null" : null); //location is null            
            Console.WriteLine(time == null ? "time is null" : time.ToString()); //1 / 1 / 0001 12:00:00 AM
            Console.ReadKey();

    
        }
    }
}

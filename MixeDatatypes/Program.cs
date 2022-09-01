using System;

namespace MixedDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3]; //An array can be of type object
            array[0] = 101;
            array[1] = "product owner";
            
            Customer cust = new Customer();
            cust.ID = 55;
            cust.Name = "Esperancito";

            array[2] = cust;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return this.Name;
            }
        }
    }
}

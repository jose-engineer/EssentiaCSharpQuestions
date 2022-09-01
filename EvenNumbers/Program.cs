using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var output = GetEvenNumbers(A);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();            
        }

        public static int[] GetEvenNumbers(int[] input)
        {
            List<int> result = new List<int>();

            for(int i=0; i<input.Length; i++)
            {                
                if (input[i] % 2 == 0) // if remainder is 0 means is even
                {
                    result.Add(input[i]);
                }
            }

            return result.ToArray();
        }
    }
}

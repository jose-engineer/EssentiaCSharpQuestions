using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("A");
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C"); // enters finally no matter what
            }
            Console.ReadKey();
        }
    }
}

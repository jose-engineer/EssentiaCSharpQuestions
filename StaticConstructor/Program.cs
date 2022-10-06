using System;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStatic t = new TestStatic();
            t.Print();
        }

        public class TestStatic //This is not a static class but can have static constructor
        {
            public static int TestValue;

            public TestStatic()
            {
                if (TestValue == 0)
                {
                    TestValue = 5;
                }
            }
            static TestStatic() //The static constructor of a class is called before any instance of the class is created.
            {
                if (TestValue == 0)
                {
                    TestValue = 10;
                }

            }

            public void Print()
            {
                if (TestValue == 5)
                {
                    TestValue = 6;
                }
                Console.WriteLine("TestValue : " + TestValue);

            }
        }
    }
}

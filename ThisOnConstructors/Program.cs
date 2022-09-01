using System;

namespace ThisOnConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA refA = new ClassA();
        }

        class ClassA
        {
            //The this keyword is used to call other constructors. 
            public ClassA() : this(10) //So that you can you call the constructor with parameters, when the Main method is called, without creating any other new instances of the ClassA
            { 
            
            }

            public ClassA(int pValue) 
            { 
            
            }
        }
    }
}

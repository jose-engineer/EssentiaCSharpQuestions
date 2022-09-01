using System;

namespace NotModifyingClass
{
    class Program
    {
        static void Main(string[] args)
        {            
            Circle obj = new Circle();

            var radius = obj.Calculate(x => x);
            var circunference = 2 * Math.PI * radius;
            
            Console.WriteLine(circunference);

            ////short elegant solution
            //Console.WriteLine(obj.CalculateCircumference(r => 2 * Math.PI * r));
        }

        public sealed class Circle {
            private double radius = 5;

            //function-valued parameters, Func generic delegate
            public double Calculate(Func<double, double> func) //First argument is the input type (double) and the second argument is the return type (double)
            {
                return func(radius);
            }
        }
    }
}

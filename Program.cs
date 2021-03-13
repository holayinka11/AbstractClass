using AbstactClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(2, 3);

            Console.WriteLine("\nrectangle1 with width=2 and height=3 is {0}", rectangle1.CalculateSurface());


            Triangle triangle1 = new Triangle(5, 10);

            Console.WriteLine("\ntriangle1 with width=5 and height=10 is {0}", triangle1.CalculateSurface());


            Circle circle1 = new Circle(7);

            Console.WriteLine("\ncircle1 with radius=7 is {0}", circle1.CalculateSurface());
        }
    }
}
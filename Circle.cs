using AbstactClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Circle : Shape
    {
        public Circle(int radius):base(radius)
        {

        }
        public override int CalculateSurface()
        {
            return Height = Width;
        }
    }
}
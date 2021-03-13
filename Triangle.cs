using AbstactClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height):base(width,height)
        {

        }
        public override int CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
using AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactClass
{
    public class Rectangle : Shape
    {
        public Rectangle( int width, int height):base(width,height)
        {

        }
        public override int CalculateSurface()
        {
            return Height * Width;
        }
    }
}

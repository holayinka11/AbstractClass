using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Shape
    {
        public int Width;
        public int Height;

        public Shape(int radius)
        {
            Width = Height = radius;
        }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public abstract int CalculateSurface();
    }
}
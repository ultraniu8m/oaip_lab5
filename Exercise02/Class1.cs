using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    public class Shape
    {
        public double height = 0;
        public double width = 0;
        public double area = 0;
        public double Height
        {
            get { return height; } 
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}

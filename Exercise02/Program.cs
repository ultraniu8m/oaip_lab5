using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle { Height = 3, Base = 4.5 };
            r.Get_area();
            var sq = new Square { Side = 3};
            sq.Get_area();
            var cir = new Circle { rad = 5 };
            cir.Get_area();
        }
    }
    public class Rectangle : Shape
    {
        public double base_ = 0;
        public double  Base {
            get { return base_; }
            set {base_ = value; } 
        }
        
        public void Get_area()
        {
            double total_ = Base * Height * 1 / 2; 
            Console.WriteLine(total_);
        }

    }
    class Square : Shape
    {
        public double side = 0;
        public Double Side
        {
            get { return side; }
            set { side = value; }
        }        
        public void Get_area()
        {
            
            double total_ = side * side;
            Console.WriteLine(total_);

        }

    }
    class Circle : Shape
    {
        const double PI = Math.PI;
        public double rad = 0;
        public double Rad
        {
            get { return rad; }
            set { rad = value; }
        }
        public void Get_area()
        {
            double total_ = Math.Pow(rad,2)*PI;
            Console.WriteLine(total_);
        }

    }

}

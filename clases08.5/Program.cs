using System;

namespace clases08._5
{
    abstract class Shape
    {
        public abstract double CalcilateArea();
        public abstract double CalcilatePerimetr();

        public void DisplayInfo()
        {
            Console.WriteLine($"Площа: {CalcilateArea()}");
            Console.WriteLine($"Периметр: {CalcilatePerimetr()}");
        }

    }

    class Triangle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double h { get; set; }

        public override double CalcilateArea()
        {
            return (a * h) / 2;
        }

         public override double CalcilatePerimetr()
        {
            return a + b + c;
        }
    }

    class Square : Shape
    {
        public double a { get; set; }

        public override double CalcilateArea()
        {
            return a * a;
        }

        public override double CalcilatePerimetr()
        {
            return a + a + a + a;
        }

    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalcilateArea()
        {
            return Math.PI * Radius * Radius; 
        }

      
        public override double CalcilatePerimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle { a = 2, b = 3, c = 2, h = 4 };
            Console.WriteLine("Трикутник");
            triangle.DisplayInfo();

            Square square = new Square { a = 4 };
            Console.WriteLine("Квадрат");
            square.DisplayInfo();

            Circle circle = new Circle { Radius = 5 };
            Console.WriteLine("Коло");
            circle.DisplayInfo();

        }
    }
}

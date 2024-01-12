using System;
using System.Globalization;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the values in the format: A B C (with spaces between)");
            string[] input = Console.ReadLine().Split();

            double a = double.Parse(input[0],CultureInfo.InvariantCulture);
            double b = double.Parse(input[1], CultureInfo.InvariantCulture);
            double c = double.Parse(input[2], CultureInfo.InvariantCulture);

            double triangle = (a * c) / 2;
            double circle = c * 3.14159;
            double trapeze = ((a + b) * c) / 2;
            double square = Math.Pow(b, 2);
            double rectangle = a * b;

            Console.WriteLine("triangle: "+triangle.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("circle: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("trapeze: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("square: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("rectangle: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}

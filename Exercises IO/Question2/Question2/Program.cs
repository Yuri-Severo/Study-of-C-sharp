/* Make a program to read the value of the radius of a circle, and then display the value of 
 * the area of this circle to four decimal places */

using System;
using System.Globalization;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the value of the radius of the circle:");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(radius,2);

            Console.WriteLine("Area = "+area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
};

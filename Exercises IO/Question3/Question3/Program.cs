using System;
using System.Globalization;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the first value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the third value:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the fourth value:");
            int d = int.Parse(Console.ReadLine());

            int result = (a*b-c*d);
            Console.WriteLine("Result = "+result);

        }
    }
}


using System;
using System.Globalization;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type two numbers (With a space between, like: 6 24)");
            string[] input = Console.ReadLine().Split(' ');

            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0) Console.WriteLine("They are divisible");

            else Console.WriteLine("They are not divisible");
        }
    }
}
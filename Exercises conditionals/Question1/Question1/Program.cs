//Make a program that read a integer number and returns if it's positive or negative

using System;
using System.Globalization;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any integer number:");
            int input = int.Parse(Console.ReadLine());

            if (input > 0) Console.WriteLine("Positive number!");

            else if (input < 0) Console.WriteLine("Negative number!");

            else if (input == 0) Console.WriteLine("That's zero!");
        }
    }
}

//Make a program that reads a integer number and return if it's Even or odd

using System;
using System.Globalization;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a integer number:");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0) Console.WriteLine("Even!");

            else Console.WriteLine("Odd!");

        }
    }
}

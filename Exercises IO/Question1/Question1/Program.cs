/* Make a program that reads the input of two integers values, makes 
 * the sum of them and show the result on the  the screen */

using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the first number:");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            int val2 = int.Parse(Console.ReadLine());
            int soma = val1 + val2;
            Console.WriteLine("SOMA = " + soma);

        }
    }
}

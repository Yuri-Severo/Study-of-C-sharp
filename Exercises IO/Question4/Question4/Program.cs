/* Make a program that reads an employee's number, the number of hours they work, the amount they are paid per hour 
 * and calculates their salary. Then display the employee's number and salary, to two decimal places. */

using System;
using System.Globalization;
namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your number (ID):");
            string id = Console.ReadLine();

            Console.WriteLine("Type your amount of hours of work:");
            int totalHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Type how much you receive per hour:");
            double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = totalHours * valueHour;

            Console.WriteLine("Number (ID): "+id);
            Console.WriteLine("Salaray = U$ "+salary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

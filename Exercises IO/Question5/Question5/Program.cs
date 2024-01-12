using System;
using System.Globalization;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the informations about the first piece: ID QUANTITY PRICE");
            string[] input = Console.ReadLine().Split(' ');

            string idPiece1 = input[0];
            int quantPiece1 = int.Parse(input[1]);
            double priceUnitPiece1 = double.Parse(input[2], CultureInfo.InvariantCulture);
            double totalPricePiece1 = quantPiece1 * priceUnitPiece1;

            Console.WriteLine("Type the informations about the second piece: ID QUANTITY PRICE");
            input = Console.ReadLine().Split(' ');

            string idPiece2 = input[0];
            int quantPiece2 = int.Parse(input[1]);
            double priceUnitPiece2 = double.Parse(input[2], CultureInfo.InvariantCulture);
            double totalPricePiece2 = quantPiece2 * priceUnitPiece2;

            double totalPrice = totalPricePiece1 + totalPricePiece2;

            Console.WriteLine("Price to pay: U$ " + totalPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/* Este é um exercício onde o foco é fixar como é feita a entrada junto com a saida de dados
Este é o código que fiz, há duas fotos na pasta deste exercício, uma sendo 
o comando e a outra a resolução do professor (caso queira comparar)  */

using System;
using System.Globalization;
namespace exercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            String nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            float precoProduto = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] input = Console.ReadLine().Split();
            string ultNome = input[0];
            int idade = int.Parse(input[1]);
            float altura = float.Parse(input[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

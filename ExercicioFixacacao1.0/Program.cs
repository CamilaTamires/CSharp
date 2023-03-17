using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)

        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("PRODUTOS:");
            Console.WriteLine($"{produto1} , cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine($"{idade} ano de idade, codigo {codigo} e genero:{genero}");

            Console.WriteLine($"medida com oito casas decimais {medida:f8}");
            Console.WriteLine($"medida com tres casas decimais {medida:f3}");
            Console.WriteLine($"medida com separador {medida}");
            Console.ReadKey();

        }
    }
}

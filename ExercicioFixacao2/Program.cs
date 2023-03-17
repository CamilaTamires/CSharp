using System;
using System.Globalization;


namespace Course
{   
    class Program

    {
        static void Main(string[] args)

        {
            Console.Write( " Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa?" );   
            int quarto = int.Parse(Console.ReadLine());
            Console.Write(" informe valor de um produtos:");
            double valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sobrenome, idade, altura. na mesma linha");
            string [] vet = Console.ReadLine().Split( ' ' );
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            float alt = float.Parse(vet[2],CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine( valor);
            Console.WriteLine( sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine( alt);
        }
    }
}

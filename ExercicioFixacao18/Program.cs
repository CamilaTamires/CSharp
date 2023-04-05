using System.Globalization;

namespace ExercicioFixacao18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("\t=== Dados do Funcionario === ");
            Console.Write(" Informe o Nome: \t");
            f.Nome = Console.ReadLine();
            Console.Write(" Informe o Salario:\tR$ ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe o Imposto:\tR$ ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\t === Salario Atual ===");

            Console.WriteLine(f);
            Console.Write("Informe qual a % de aumento a ser aplicado:\t");
            double PorcAum = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.SalarioAumento(PorcAum);
            Console.WriteLine("\t === Salario Atualizado ===");
            Console.WriteLine(f);


        }
    }
}
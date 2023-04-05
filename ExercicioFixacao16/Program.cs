using System.Globalization;

namespace ExercicioFixacao16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double media = 0;

            Console.Write(" Informe nome do Funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.Write(" Informe Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write(" Informe nome do Funcionario: ");
            f2.Nome = Console.ReadLine();
            Console.Write(" Informe Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (f2.Salario + f1.Salario) / 2;
            Console.WriteLine( $" Media salarial  {media.ToString("f2",CultureInfo.InvariantCulture)}");
        }
    }
}
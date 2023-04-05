using System.Globalization;

namespace ExercicioFixacao19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Estudante = new Aluno();

            Console.Write(" Nome do Aluno:\t");
            Estudante.Nome = Console.ReadLine();
            Console.WriteLine("Informe as tres notas de " + Estudante.Nome);
            Estudante.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Estudante.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Estudante.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {Estudante.NotaFinal().ToString("F2", CultureInfo.InvariantCulture))}");

            if (Estudante.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + Estudante.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

        }
    }
}
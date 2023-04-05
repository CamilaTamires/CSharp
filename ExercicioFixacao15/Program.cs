using System.Security.Cryptography.X509Certificates;

namespace ExercicioFixacao15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Entre com nome: ");
            x.Nome = Console.ReadLine();
            Console.Write($"Informe Idade de {x.Nome}:");
            x.Idade = int.Parse( Console.ReadLine() );
            Console.Write(" Entre com outro nome :");
            y.Nome = Console.ReadLine();
            Console.Write($"Informe Idade de {y.Nome} :");
            y.Idade = int.Parse( Console.ReadLine() );

            if ( y.Idade >  x.Idade)
            {
                Console.WriteLine( $" {y.Nome} é mais velho(a)! ");
            }
            else
            {
                Console.WriteLine($" {x.Nome} é mais velho(a)! ");
            }

        }
    }
}
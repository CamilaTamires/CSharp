using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace ExercicioFixacao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de divisões que deseja realizar: ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= x; i++)
            {
                Console.Write( "Digite dois valores que deseja dividir: ");
                string[] vet = Console.ReadLine().Split(' ');
                float y = float.Parse(vet[0]);
                float z = float.Parse(vet[1]);
                if (y < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\a Divisão Imposivel");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    float r = y / z;
                    Console.WriteLine(r);
                }


            }
        }
    }
}
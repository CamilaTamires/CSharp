
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExercicioFixacao11
{ /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos
   * no sistema cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo
   * será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem
   * escrever mensagem alguma).   */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe duas cordenadas:  ");
            string[] vet = Console.ReadLine().Split(' ');
            int y = int.Parse(vet[0]);
            int x = int.Parse(vet[1]);
            while ( x != 0 && y !=0)
            {
                if (x > 0 && y > 0) { Console.WriteLine("PRIMEIRO"); }
                else if (y < 0 && x > 0) { Console.WriteLine("SEGUNDO"); }
                else if (y < 0 && x < 0) { Console.WriteLine(" TERCEIRO"); }
                else if (y > 0 && x < 0) { Console.WriteLine("QUARTO"); }

                Thread.Sleep(3000);
                Console.Clear();
                Console.Write("informe novas cordenadas: ");
                vet = Console.ReadLine().Split(' ');
                y = int.Parse(vet[0]);
                x = int.Parse(vet[1]);

            }

            Console.Clear();

        }
    }
}
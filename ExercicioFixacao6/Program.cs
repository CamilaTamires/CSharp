using System.Drawing;

namespace ExercicioFixacao6
{
    internal class Program
    {    // Programa para verificar se valor é negativo,positivo ou neutro

        static void Main(string[] args)
        {  
            int valor;


            Console.Write("Informe o numero que deseja verificar: ");
            valor = int.Parse(Console.ReadLine());


            if (valor > 0)
            {
                Console.WriteLine(" NUMERO É POSITIVO");
            }
            else if (valor == 0)
            {
                Console.WriteLine("VALOR NEUTRO");
            }
            else
            {
                Console.WriteLine(" NUMERO É NEGATIVO");


            }
            }
            
    }
}
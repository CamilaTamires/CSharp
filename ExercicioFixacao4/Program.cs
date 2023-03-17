using System.Threading.Channels;

namespace ExercicioFixacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Entre com quatro valores, na mesma linha");
            string [] vet = Console.ReadLine().Split(' ');
            int v1 = int.Parse(vet[0]);
            int v2 = int.Parse(vet[1]);
            int v3 = int.Parse(vet[2]);
            int v4 = int.Parse(vet[3]);
            int resultado = (v1 * v2 - v3 * v4);
            
            Console.WriteLine($" DIFERENÇA= {resultado}");



        }
    }
}
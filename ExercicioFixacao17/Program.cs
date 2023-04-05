using System.Formats.Asn1;
using System.Globalization;

namespace ExercicioFixacao17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r =  new Retangulo();
            

            Console.Write("Entre com Altura do Retangulo: ");
            r.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com Largura do Retangulo: ");
            r.L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro " + r.Perimetro().ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal " + r.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
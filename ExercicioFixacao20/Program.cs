using System.Globalization;


namespace ExercicioFixacao20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a Cotação do Dolar: ");
            ConversorDeMoeda.ValorDolar = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quanto deseja comprar: ");
            ConversorDeMoeda.QuantDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser Pago R$ {ConversorDeMoeda.PagarDolar().ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
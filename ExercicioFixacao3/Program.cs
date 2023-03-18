using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double area = 0;
            double raio = 0;
            Console.Write("Entre com valor raio:");
            raio = double.Parse(Console.ReadLine());
            area = pi * (raio*raio);
            Console.WriteLine($" A area é {area:F4}");

        }
    }
}

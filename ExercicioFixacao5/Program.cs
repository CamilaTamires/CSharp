namespace ExercicioFixacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            Console.Write("Digite valor de A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Digite valor de B: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Digite valor de C: ");
            float c = float.Parse(Console.ReadLine());

            double resposta = a*c/2;
            Console.WriteLine($"TRIANGULO: {resposta:F3}");
            resposta = (c*c) * pi;
            Console.WriteLine($"CIRCULO: {resposta:F3}");
            resposta = (a + b) * c / 2;
            Console.WriteLine($"TRAPEZIO: {resposta:F3}");
            resposta = (b * b);
            Console.WriteLine($"QUADRADO: {resposta:F3}");
            resposta = (a * b);
            Console.WriteLine($"RETANGULO: {resposta:F3}");

        }
    }
}
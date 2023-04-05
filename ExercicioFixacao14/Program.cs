namespace ExercicioFixacao14
{
    internal class Program
    {  /*O programa deve então mostrar na tela N linhas,começando de 1 até N. Para cada linha
        * mostrar o número da linha, depois o quadrado e o cubo do valor. */
        static void Main(string[] args)
        {

            Console.Write("Digite um Numero: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int y = i * i;
                int z = y * i;
                Console.WriteLine($" {i}  {y}  {z}");
            }
        }
    }
}
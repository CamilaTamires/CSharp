namespace ExercicioFixacao12
{  
    internal class Program
    {   /* Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um
         * valor por linha, inclusive o X, se for o caso */
        static void Main(string[] args)
        {

            Console.Write(" Digite o valor: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
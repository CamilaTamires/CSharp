namespace ExercicioFixacao7
{ // Programa para verificar se 2 valores digitados sao  multiplos de 2
    internal class Program
    {
        static void Main(string[] args)
        {
            int A; int B;

            Console.Write("Informe dois valores: ");
            string[] vet = (Console.ReadLine().Split(" "));
             A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            Console.Clear();
            if ( A % 2 == 0 && B % 2 == 0)
            {
                Console.WriteLine(" São multiplos! ");
            }
           else if (B % 2 == 0 && A % 2 == 0)
            {
                Console.WriteLine(" São multiplos! ");
            }
            else { Console.WriteLine("Não são multiplos");
            }
        }
        
    }
}
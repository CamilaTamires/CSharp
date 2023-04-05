using System.Diagnostics.Tracing;

namespace ExercicioFixacao8
{ // Programa calcula duração de um jogo sendo min 1h e max 24h 

    internal class Program
    {
        static void Main(string[] args)
        {
            const int dia = 24;
            
            Console.Write("Informe a hora Inicio e fim: ");
            string[] vet = (Console.ReadLine().Split(' '));
            int inicio= int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);

            if (inicio >24 || fim > 24)
            {
                Console.WriteLine(" HORA INVALIDA\a");
            }
            else if (inicio == fim) {
                Console.WriteLine("24horas");
            }
            else if ((inicio > 11 && fim > 11) || (inicio < 11 && fim > 11))
            {
                int r = (fim - inicio);
                Console.WriteLine(r + " hora");
            }
            else if ((inicio > 11 && fim < 12)){
                int r = (dia - inicio + fim);
                Console.WriteLine(r + "hora");
           
            }
        } 
    }
    
}
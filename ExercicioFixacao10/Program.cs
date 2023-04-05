using System;
using System.Net.Http.Headers;
using System.Threading;

namespace ExercicioFixacao10
{/*programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
  * incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada
  * corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo
  * encerrado.Considere que a senha correta é o valor 2002.*/
    internal class Program
    {   
        static void Main(string[] args)
        {
            const int senha = 2023;

            Console.Write("Digite Senha: ");
            int senhaD = int.Parse(Console.ReadLine());
              while (senha != senhaD) {
                Console.WriteLine("\aSENHA INVALIDA!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Digite senha:");
                 senhaD = int.Parse(Console.ReadLine());
            }
              Console.Clear() ;
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
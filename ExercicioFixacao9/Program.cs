namespace ExercicioFixacao9
{  //Programa calcula valor de um pedido lanchonete
        internal class Program
    {
        static void Main(string[] args)
        {  
            float CQ = 4.00f;
            float XS = 4.50f;
            float XB = 5.00f;
            float TS = 2.00f;
            float REFRI = 1.50f;

            Console.WriteLine("=============================================");
            Console.WriteLine($"CODIGO# 01\tCACHORRO QUENTE\tR${CQ:F2}");
            Console.WriteLine($"CODIGO# 02\tX - SALADA\tR${XS:F2}");
            Console.WriteLine($"CODIGO# 03\tX - BACON\tR${XB:F2}");
            Console.WriteLine($"CODIGO# 04\tTORRADA SIMPLES\tR${TS:F2}");
            Console.WriteLine($"CODIGO# 05\tREFRIGERANTE\tR${REFRI:F2}");
            Console.WriteLine("=============================================");
            Console.Write("\n digite o codigo e quantidade do produto");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quant = int.Parse(vet[1]);

         
            }

        }
    }

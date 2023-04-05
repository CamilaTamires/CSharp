using System;

namespace ExercicioFixacao20
{
    internal class ConversorDeMoeda
    {
        public static double ValorDolar;
        public static double QuantDolar;

        public static double PagarDolar ()
        {
            return (ValorDolar * QuantDolar * 0.06) + (ValorDolar * QuantDolar) ;

        }
        
    }
}

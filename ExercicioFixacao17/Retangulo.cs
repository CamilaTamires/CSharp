using System;


namespace ExercicioFixacao17
{
    internal class Retangulo
    {
        public double A;
        public double L;

        public double Area ()
        {
            return  A * L; 
        }

        public double Perimetro ()
        {
            return A + A + L + L;
        }

        public double Diagonal()
        {
            return Math.Sqrt((A * A)+ (L * L));
        }
    }
}

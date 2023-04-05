using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao18
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return  SalarioBruto - Imposto; ;
        }
       public void SalarioAumento ( double salariobruto )
        {
             SalarioBruto = SalarioBruto * (salariobruto / 100) + SalarioBruto;
        }

        public override string ToString()
        {
            return ($"{Nome}, R${SalarioLiquido().ToString("f2",CultureInfo.InvariantCulture)}");
        }
    }
}

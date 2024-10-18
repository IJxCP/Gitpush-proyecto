using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class PotenciaBase10 : Operacion
    {
        public PotenciaBase10(double exponente) : base(10, exponente) { }

        public override double Calcular()
        {
            return Math.Pow(Primero, Segundo); // Eleva 10 a la potencia del exponente
        }
    }

}

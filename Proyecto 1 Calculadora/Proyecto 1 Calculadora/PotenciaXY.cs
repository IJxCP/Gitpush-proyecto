using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class PotenciaXY : Operacion
    {
        public PotenciaXY(double baseNum, double exponente) : base(baseNum, exponente) { }

        public override double Calcular()
        {
            return Math.Pow(Primero,Segundo); // Eleva x a la potencia de y
        }
    }

}

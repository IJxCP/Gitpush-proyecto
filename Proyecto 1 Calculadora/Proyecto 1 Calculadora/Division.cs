using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class Division : Operacion
    {
        public Division(double primero, double segundo) : base(primero, segundo) { }

        public override double Calcular()
        {
            if (Segundo == 0)
                throw new DivideByZeroException("División por cero no permitida.");
            return Primero / Segundo;
        }
    }
}

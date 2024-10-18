using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class Multiplicacion : Operacion
    {
        public Multiplicacion(double primero, double segundo) : base(primero, segundo) { }

        public override double Calcular()
        {
            return Primero * Segundo;
        }
    }
}

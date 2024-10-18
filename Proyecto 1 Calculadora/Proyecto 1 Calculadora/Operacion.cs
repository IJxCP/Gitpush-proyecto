using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public abstract class Operacion
    {
        protected double Primero { get; set; }
        protected double Segundo { get; set; }

        public Operacion(double primero, double segundo)
        {
            Primero = primero;
            Segundo = segundo;
        }

        public abstract double Calcular();
    }
}

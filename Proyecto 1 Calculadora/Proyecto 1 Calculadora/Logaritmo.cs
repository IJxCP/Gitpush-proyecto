using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class Logaritmo
    {
        private double Numero;

        public Logaritmo(double numero)
        {
            Numero = numero;
        }

        public double Calcular()
        {
            if (Numero <= 0)
                throw new InvalidOperationException("El logaritmo no está definido para números menores o iguales a cero.");
            return Math.Log10(Numero);
        }
    }
}
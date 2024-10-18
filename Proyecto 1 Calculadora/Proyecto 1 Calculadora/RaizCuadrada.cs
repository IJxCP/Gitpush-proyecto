using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class RaizCuadrada
    {
        private double Numero;

        public RaizCuadrada(double numero)
        {
            Numero = numero;
        }

        public double Calcular()
        {
            if (Numero < 0)
                throw new InvalidOperationException("La raíz cuadrada no está definida para números negativos.");
            return Math.Sqrt(Numero);
        }
    }
}

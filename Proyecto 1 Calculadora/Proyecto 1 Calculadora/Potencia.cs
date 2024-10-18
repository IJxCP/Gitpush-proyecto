using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Calculadora
{
    public class Potencia
    {
        private double Base;
        private double Exponente;

        public Potencia(double baseNum, double exponente)
        {
            Base = baseNum;
            Exponente = exponente;
        }

        public double Calcular()
        {
            return Math.Pow(Base, Exponente);
        }
    }

}

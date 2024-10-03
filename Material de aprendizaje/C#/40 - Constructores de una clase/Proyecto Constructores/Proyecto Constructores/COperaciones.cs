using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructores
{
    class COperaciones
    {
        private double Numero1, Numero2;
        public COperaciones(double n1, double n2)
        {
            Numero1 = n1;
            Numero2 = n2;
        }
        public double Suma()
        {
            return Numero1 + Numero2;
        }
        public double Resta()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public double Division()
        {
            return Numero1 / Numero2;
        }
        public void Mensaje()
        {
            Console.Write("El resultado de la ");
        }
    }
}

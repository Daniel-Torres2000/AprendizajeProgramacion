using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_OperacionesBasicas
{
    class OpBasicas
    {
        public double Suma(double n1, double n2)
        {
            double Operar = 0;
            try
            {
                Operar = n1 + n2;
            }
            catch (FormatException) { }
            return Operar;
        }
        public double Resta(double n1, double n2)
        {
            double Operar = 0;
            try
            {
                Operar = n1 - n2;
            }
            catch (FormatException) { }
            return Operar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_OperacionesBasicas
{
    class Ccompuestas:OpBasicas
    {
        public OpBasicas valor = new OpBasicas();
        public Ccompuestas()
        {

        }
        public int Multiplicacion(int n1, int n2)
        {
            int Cont = 1;
            int op = 0;
            while (Cont <= n2)
            {
                valor.Suma(op, n1);
                Cont++;
            }
            return op;
        }
        public double Division(double n1, double n2)
        {
            int cont = 1;
            double op = n1;
            double resultado = 0;
            while (op >= 0)
            {
                op = valor.Resta(op, n2);
                cont++;
                if (op >= 0)
                    resultado = resultado + 1;
            }
            return (resultado);
        }
    }
}

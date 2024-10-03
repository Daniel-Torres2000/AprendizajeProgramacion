using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    class C_cuadrado:C_forma
    {
        public void mostrar()
        {
            C_cuadrado instancia = new C_cuadrado();
            instancia.yosoy();
            Console.WriteLine("TENGO CUATRO LADOS DEL MISMO TAMAÑO");
        }
    }
}

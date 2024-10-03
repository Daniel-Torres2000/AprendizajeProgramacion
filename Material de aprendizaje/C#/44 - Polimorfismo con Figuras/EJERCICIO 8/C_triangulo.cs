using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    class C_triangulo:C_forma
    {
        public void mostrar()
        {
            C_triangulo instancia = new C_triangulo();
            instancia.yosoy();
            Console.WriteLine("MIS TRES LADOS TIENDEN A CAMBIAR");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    class C_circulo: C_forma
    {
        public void mostrar()
        {
            C_circulo instancia = new C_circulo();
            instancia.yosoy();
            Console.WriteLine("TENGO UNA LINEA SIN COMIENZO NI FIN");
        }
    }
}

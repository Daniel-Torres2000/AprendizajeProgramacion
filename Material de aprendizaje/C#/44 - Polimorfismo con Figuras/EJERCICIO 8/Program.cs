using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*REALIZAR UN PROGRAMA QUE POSEA UNA CLASE BASE LLAMADA C_forma, y tres clases derivadas
             * llamadas C_cuadrado, C_triangulo, C_circulo. Cada clase es heredada de C_forma y cada clase
             * tiene un metodo distinto para mostrar sus caracteristicas unicas dependiendo la forma*/
            C_circulo instancia = new C_circulo();
            C_cuadrado instancia2  = new C_cuadrado();
            C_triangulo instancia3 = new C_triangulo();
            instancia.mostrar();
            instancia2.mostrar();
            instancia3.mostrar();
            Console.ReadKey();
        }
    }
}

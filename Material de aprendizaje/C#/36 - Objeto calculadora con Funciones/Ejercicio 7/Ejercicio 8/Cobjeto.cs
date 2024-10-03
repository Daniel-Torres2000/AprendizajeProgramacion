using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Cobjeto
    {
        double n1, n2, resultado;
        public void suma()
        {
            Cobjeto instancia = new Cobjeto();
            Console.WriteLine("INGRESE DOS NUMEROS: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = (n1 + n2);
            Console.WriteLine("RESULTADO: " + resultado);
            Console.ReadKey();
            instancia.menu_principal();
        }
        public void resta()
        {
            Cobjeto instancia = new Cobjeto();
            Console.WriteLine("INGRESE DOS NUMEROS: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = (n1 - n2);
            Console.WriteLine("RESULTADO: " + resultado);
            Console.ReadKey();
            instancia.menu_principal();
        }
        public void multiplicacion()
        {
            Cobjeto instancia = new Cobjeto();
            Console.WriteLine("INGRESE DOS NUMEROS: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = (n1 * n2);
            Console.WriteLine("RESULTADO: " + resultado);
            Console.ReadKey();
            instancia.menu_principal();
        }
        public void division()
        {
            Cobjeto instancia = new Cobjeto();
            Console.WriteLine("INGRESE DOS NUMEROS: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = (n1 / n2);
            Console.WriteLine("RESULTADO: " + resultado);
            Console.ReadKey();
            instancia.menu_principal();
        }
        public void menu_principal()
        {
            int opcion;
            Cobjeto instancia = new Cobjeto();
            Console.Clear();
            Console.WriteLine("\tMENU");
            Console.WriteLine("1.SUMA");
            Console.WriteLine("2.RESTA");
            Console.WriteLine("3.MULTIPLICACION");
            Console.WriteLine("4.DIVISION");
            Console.WriteLine("5.SALIR");
            Console.WriteLine();
            Console.Write("OPCION: "); 
            opcion = Convert.ToInt32(Console.ReadLine());
            if(opcion==1)
            {
                instancia.suma();
            }
            else
            {
                if (opcion == 2)
                {
                    instancia.resta();
                }
                else
                {
                    if (opcion == 3)
                    {
                        instancia.multiplicacion();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            instancia.division();
                        }
                        else
                        {
                            if(opcion==5)
                            {
                                Console.WriteLine();
                                Console.WriteLine("VUELVA PRONTO!!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if(opcion != 5)
                            {
                                Console.WriteLine();
                                Console.WriteLine("OPCION INVALIDA");
                                Console.ReadKey();
                                Console.Clear();
                                instancia.menu_principal();
                            }
                        }
                    }
                }
            }
            


        }
    }
}

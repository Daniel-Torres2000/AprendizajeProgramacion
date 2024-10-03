using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que simule iniciar sesion en office 365, pida un correo electronico y una contraseña,
              se debe verificar que ambos sean correctos, de lo contario debe mostrar, mensaje datos invalidos.
              Los datos base son:
              Correo = "programacion2019@icvh.edu.gt, Contraseña = "COMPUPROGRA"
              
              El usuario debe tener tres intentos disponibles, cada vez que falle un intento se debe limpiar pantalla
              (eliminar la informacion que se ve en la pantalla), si falla los tres intentos, mostrar un mensaje
              Intentelo mas tarde. Se utilizaran ciclos y contadores.
             */
            string correo, contra;
            int contador = 1;

            do
            {
                Console.WriteLine("INGRESE CORREO ELECTRONICO: ");
                correo = Console.ReadLine();
                //Debemos recordar que los datos tipo string no se deben convertir
                Console.WriteLine("INGRESE CONTRASEÑA: ");
                contra = Console.ReadLine();

                if ((correo == "programacion2019@icvh.edu.gt") && (contra == "COMPUPROGRA"))
                {
                    Console.WriteLine("BIENVENIDO");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("DATOS INVALIDOS");
                    Console.ReadKey();
                    contador++;
                }
                if(contador==4)
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("INTENTELO MAS TARDE");
                    Console.ReadKey();
                }                
                Console.Clear();
            } while (contador <= 3);
        }
    }
}

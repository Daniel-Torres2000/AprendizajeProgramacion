using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que simule iniciar sesion en office 365, pida un correo electronico y una contraseña,
              se debe verificar que ambos sean correctos, de lo contario debe mostrar, mensaje datos invalidos.
              Los datos base son:
              Correo = "lostomatitos123@icvh.edu.gt, Contraseña = "LaS0pa"*/
            string correo, contra;
            Console.WriteLine("INGRESE CORREO ELECTRONICO: ");
            correo = Console.ReadLine();
            //Debemos recordar que los datos tipo string no se deben convertir
            Console.WriteLine("INGRESE CONTRASEÑA: ");
            contra = Console.ReadLine();

            if((correo=="lostomatitos123@icvh.edu.gt")&&(contra=="LaS0pa"))
            {
                Console.WriteLine("BIENVENIDO");
            }
            else
            {
                Console.WriteLine("DATOS INVALIDOS");
            }
            Console.ReadKey();
        }
    }
}

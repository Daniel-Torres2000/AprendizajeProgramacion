using System;
namespace Practica09
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            double decimales = 10.234;
            decimales = Math.Round(decimales,2); //la funcion de la clase Math permite redondear decimales con la funcion
            //Round, en este caso necesitamos mostrar solo dos decimales
            Console.WriteLine("Dos decimales: " + decimales);
        }
    }
}
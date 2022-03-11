using System;
namespace Practica03
{
    public class Program
    {
        public static void Main(String[] args)
        {
            /*Para declarar correctamente una variable se debe especificar el tipo
             * de dato, seguido del identificador de la variable, y si se necesita
             * se puede asignar el valor a la variable 
             * */
            int num = 5; //int es el tipo, es una variable entera
            //num, es el identificador de la variable
            //el operador = igual, permite asignar el valor a la variable
            //el valor que se le asigna a la variable num es cinco
            Console.WriteLine(num); //con esto imprimimos la variable num en pantalla
            //podemoss concatenar un texto, junto con la variable
            Console.WriteLine("Variable num: " + num);
            //con el loperador + concatenmos el texto con la variable
            Console.WriteLine("Variable num metodo dos: {0}", num);
            //con las llaves, y el numero asignamos la cantidad de variables que se
            //utilizaran, y conforme vayan apareciendo, ses mostrara con un iterador
            //de posicioness, que siempre comienza con cero "0"

            var num2 = num + 10; //el uso del tipo var, es una vaariable inteligente
            //var asigna el tipo de dato, ddependiendo la asignación de valor sobre la variable
            Console.WriteLine(num2+5);
            //aqui, mostraamoss la variable num2, y se le suma cinco, es decir
            //num2, vale 15 inicialmente mas cinco, son en total 20
        }
    }
}
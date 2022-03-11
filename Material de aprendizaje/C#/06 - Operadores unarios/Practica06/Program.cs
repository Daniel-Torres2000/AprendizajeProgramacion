using System;
namespace Practica06
{
    public class Program
    {
        public static void Main(String[] args)
        {
            double residuo, division;
            int n1, n2, suma, resta, multiplicacion;
            n1 = 10; n2 = 20;
            suma = n1 + n2;
            resta = n1 + n2;
            multiplicacion = n1 * n2;
            division = n1 / n2;
            residuo = n1 % n2; //con el operador de porcentaje, permite que podamos
            //sacar el residuo de la divivsion de dos valores es decir

            // 10 / 7 = 1
            //residuo es 3, es el sobrante de la division
            Console.WriteLine("Suma de {0} + {1} = {2}", n1, n2, suma);
            Console.WriteLine("Suma de {0} - {1} = {2}", n1, n2, resta);
            Console.WriteLine("Suma de {0} * {1} = {2}", n1, n2, multiplicacion);
            Console.WriteLine("Suma de {0} / {1} = {2}", n1, n2, division);
            Console.WriteLine("Suma de {0} % {1} = {2}", n1, n2, residuo);

            //especificamos las posiciones en donde se imprimiran las variables
            //tomando siempre la consideracion que iterador las posiciones comienza en cero " 0 "
        }
    }
}
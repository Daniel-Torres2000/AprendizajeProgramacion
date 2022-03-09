package Operadores;
public class Presedencias {
    public static void main (String args[])
    {
        //es importante respetar la jerarquía de operadores matemáticos
        var n1 = 10 + 8 * 4; //por orden de jararquía se opera primero la multiplicacion y posteriormente la suma
        System.out.println("n1: "+n1);
    }
}

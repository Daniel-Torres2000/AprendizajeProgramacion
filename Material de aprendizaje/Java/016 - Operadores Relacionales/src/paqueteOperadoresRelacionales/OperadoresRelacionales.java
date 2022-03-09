
package paqueteOperadoresRelacionales;
public class OperadoresRelacionales {
    public static void main (String args[])
    {
        int n1, n2;
        n1 = 20;
        n2 = 30;
        var n3 = n1 >= n2; //por lo tanto se sabe que el valor de n3 es false
        n3= !n3; //y aquí damos el valor opuesto
        if(n3==true) //igual o igual que, debe ser identico al valor condicionado
        {
            System.out.println("El valor de n3 se cambio exitosamente");
        }
        var n4 = n1+n2;
        if(n4%2==0)//el porcentaje representa el residuo, si el residuo es cero es un valor par
        {
            System.out.println("El valor de n4 es un numero par");
        }
        if(n4 >= 50)//estructuramos un criterio de mayor o igual que cincuenta, si se cumple mostramos un texto
        {
            System.out.println("El valor de n4, es mayor o igual que 50");
        }
        if(n4 <= 50) //estructuramos un criterio menor o igual que cincuenta, por tanto se mostrara un mensaje
        {
            System.out.println("El valor de n4, es menor o igual que 50");
        }
        if(n4 != 100) //si n4 es diferente de 100 mostraremos un mensaje
        {
            System.out.println("n4 es diferente de 100");
        }
    }
}

package PaqueteOperadoresRelacionales;
public class OperadoresRelacionales {
    public static void main (String args[])
    {
        String name = "Daniel"; //evaluaremos condicionales con cadenas de texto
        int edad = 25;
        if((name == "Daniel")&&(edad >= 18)) //establecemos una doble condicion
        {
            System.out.println("Mucho gusto Daniel, Usted es mayor de edad");
        }else{
            System.out.println("Usted no es Daniel, Tenga buen dia");
        }
        if(name=="Daniel" && edad >= 18) //es otra manera posible de evaluar una doble condicional y asi agregar mas condiciones
        {
            System.out.println("Hola Daniel, eres mayor de edad");
        }else{
            System.out.println("Hola, Buen dia");
        }
        name = "Hector";
        if(name == "Daniel" || name == "Hector")
        {
            System.out.println("Eres Hector o Daniel, De igual manera eres bienvenido");
        }else{
            System.out.println("No eres ninguno de los administradores, buen dia");
        }
    }
}

public class Inferencias {
    public static void main (String args[])
    {
        var variableDato = 10; //var es un tipo de inferencia de datos en java
        //java identifica y asigna el tipo de dato adecuado para la variable var, en este caso entera
        System.out.println("VariableDatos: "+variableDato+"\n"); //slash seguido de n, automáticamente inserta un salto de linea
        
        //Para ver la version JDK el kit de java, instalada en el proyecto hacemos los siguientes pasos
        /*
        1. Click derecho sobre el proyecto
        2. Propiedades
        3. Visualizar en la parte inferior version JDK de java
        */
        
        var variableDato2 = "Hola a todos"; //se infiere un dato de tipo cadena
        System.out.print(variableDato2+"\n"); //si solo usamos el comando print, no aplica ningun salto de linea
    }
}

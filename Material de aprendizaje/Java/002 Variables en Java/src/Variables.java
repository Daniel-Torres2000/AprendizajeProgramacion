public class Variables {
    public static void main (String args[])
    {
        //implementación de variables en Java
        int variableEntera = 10; //variable de tipo entero a la cual le asignamos un valor inicializado
        System.out.println("Valor de variableEntera: "+variableEntera);//+ concatena a la cadena de texto la variable n
        //Si implementamos netbeans, podemos hacer uso de la función de refactorización nos permite modificar nombres de variables
        //o identificadores en todo el proyecto, renombrandolos o reorganizando el codigo mismo
        
        //las variables se recomiendan iniciarlas con minuscula y las clases con mayuscula, al agregar otra palabra al identificador
        //se recomienda inicializarla con mayuscula
        //se le conoce a este proceso como connotación de camello o connotación de altas y bajas
        
        //Modificaremos el valor de la variable
        variableEntera = 5;
        System.out.println("Valor nuevo de variableEntera1: "+variableEntera);
        String variableCadena = "Saludos a todos"; //declaramos una variable de tipo cadena String
        System.out.println(variableCadena); //imprimimos la variable cadena
    }
}

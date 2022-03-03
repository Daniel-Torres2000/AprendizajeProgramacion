public class ConcatenarEnJava {
    public static void main (String args[])
    {
        //concatenar quiere decir, unir dos o mas cadenas, o valores de datos
        var estudiante = "Ronaldo";
        var especialidad = "Tecnico en redes";
        var datosCompletos = especialidad+" "+estudiante;
        System.out.println(datosCompletos); //con el operador + estamos concatenando cadenas
        /*
            asdfasdf
                    asdfads
                        asdf
        a   asdf        asdf
            Si en algun momento tenemos informacion, de sordenado el formato como se presento en este ejemplo de comentario
            mediante netbeans podemos dar click derecho y format, automaticamente reorganiza el codigo automaticamente
        */
        
        //nosotros podemos imprimir el resultado de una suma sin una variable auxiliar ejemplo siguiente
        int n1 = 5, n2 = 10, aux = n1 + n2;
        System.out.println("Suma: "+aux);
        System.out.println(n1+n2); //aqui operamos la suma sin una variable de resultado se debe tener cuidado con estos procesos
        //si concatenamos un texto con un numero, en ese caso si convertiriamos la informacion en una linea de texto es decir
        System.out.println("Numeros concatenados no sumados "+n1+n2); //veremos que aqui se concatena, no se suma
        
        //concatenar cadena a una operacion, sin usar variable auxiliar
        System.out.println("Resultado suma: "+ (n1 + n2)); //concatena el texto con el resultado de la suma
    }
}

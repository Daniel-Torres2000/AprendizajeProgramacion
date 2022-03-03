public class CaracteresEspeciales {
    public static void main (String args[])
    {
        var cadenaTexto = "Estudios en programacion java";
        System.out.println("Salto de linea \n"+cadenaTexto);
        System.out.println("Tabulador \t"+cadenaTexto);
        System.out.println("Retroceso:_\b\b"+cadenaTexto);//borraremos el guion bajo y los dos puntos
        System.out.println("Comillas simples: \'"+cadenaTexto+"\'");//si solo imprimimos las comillas simples estamos dandole otro uso
        System.out.println("Comillas dobles: \""+cadenaTexto+"\""); //al igual que con las comillas simples aplicamos el mismo codigo
    }
}

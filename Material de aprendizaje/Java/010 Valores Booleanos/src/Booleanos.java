import java.util.Scanner;
public class Booleanos {
    public static void main (String args[])
    {
        boolean bandera = true; //los valores booleanos pueden ser verdaderos o falsos
        System.out.println("bandera: "+bandera);
        if(bandera){ //estructuras condicionales en java if si se cumple la condición es decir se bandera es verdadero ejecuta inst.1
            System.out.println("La bandera es verdadera");//inst1 se cumple la condicion entonces se ejecuta este codigo
        }else{
            System.out.println("La bandera es falsa");//inst del else, en caso de no cumplirse el if, pasamos al sino
        }
        int dato = 0; //inicializamos el valor de dato en cero y luego leemos por la consola de Scanner
        Scanner consola = new Scanner(System.in);
        System.out.println("Digite un numero: "); dato = consola.nextInt();
        var bandera2 = dato%2==0; //creamos una variable de tipo var, que identifica automaticamente el valor booleano
        //la condicion es si dato residuo de dos es cero, entonces tomara el valor ya sea verdadero o falso
        System.out.println("bandera2: "+bandera2);
        if(bandera2){ //si el valor ingresado es par, o sea el residuo da cero, entonces se cumplen las instrucciones del if
            System.out.println("La bandera2 es verdadera, o sea el dato entero es par");
        }else{ //si el numero es impar se ejecuta el else
            System.out.println("La bandera2 es falsa, o sea el dato entero es impar");
        }
    }
}

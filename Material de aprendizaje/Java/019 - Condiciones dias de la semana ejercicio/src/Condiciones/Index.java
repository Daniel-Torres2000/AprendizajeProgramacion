package Condiciones;
import java.util.Scanner;
public class Index {
    public static void main (String args[])
    {
        int dia;
        Scanner console = new Scanner(System.in);
        System.out.println("Digite un numero del 1 al 7");
        dia = console.nextInt();
        if(dia==1){
            System.out.println("Lunes");
        }else if(dia==2){
            System.out.println("Martes");
        }else if(dia==3){
            System.out.println("Miercoles");
        }else if(dia==4){
            System.out.println("Jueves");
        }else if(dia==5){
            System.out.println("Viernes");
        }else if(dia==6){
            System.out.println("Sabado");
        }else if(dia==7){
            System.out.println("Domingo");
        }else{
            System.out.println("No corresponde a ningun dia de la semana");
        }
    }
}

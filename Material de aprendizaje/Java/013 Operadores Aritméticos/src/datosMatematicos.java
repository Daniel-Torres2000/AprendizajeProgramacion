import java.util.Scanner;
public class datosMatematicos {
    public static void main (String args[])
    {
        int num1, num2;
        Scanner console = new Scanner(System.in);
        System.out.println("Insert two numbres: ");
        num1 = console.nextInt(); console.nextLine();
        num2 = console.nextInt(); console.nextLine();
        
        System.out.println("Addition: "+(num1+num2));
        System.out.println("Substraction: "+(num1-num2));
        System.out.println("Multiplication: "+(num1*num2));
        System.out.println("Division: "+(num1/num2));        
    }
}

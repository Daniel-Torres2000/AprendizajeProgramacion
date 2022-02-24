//Programa que permita ingresar dos numeros y mostrar operaciones basicas con ellos
#include<iostream>
#include<conio.h>
using namespace std;
int main(){
	int num1, num2, suma, resta, multi, divi;
	printf("Digite valor num1: "); scanf("%i",&num1);
	printf("Digite valor num2: "); scanf("%i",&num2);
	suma = num1 + num2;
	resta = num1 - num2;
	multi = num1 * num2;
	divi = num1 / num2;
	system("pause"); //genera una pausa en pantalla mostrando un breve texto hasta presionar tecla
	printf("Resultados son:\n");
	printf("Suma: %i\nResta: %i\nMultiplicacion: %i\nDivision: %i\n", suma,resta,multi,divi);
	getch(); //genera una pausa en pantalla sin mostrar ningun texto hasta presionar tecla
	return 0;
}

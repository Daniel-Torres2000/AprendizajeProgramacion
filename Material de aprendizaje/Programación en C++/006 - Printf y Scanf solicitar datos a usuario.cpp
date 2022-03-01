//Programa que permita solicitar datos al usuario y almacenarlos en una variable
#include<iostream>
#include<string>
#include<stdlib.h>
#include<conio.h>
using namespace std;
int main(){
	int edad;
	string nameComplete;
	float weight;
	printf("\tUser Data\n");
	//al utilizar \t especificamos que la informacion aplique una tabulacion
	// el \n es un salto de linea
	//printf imprimir en pantalla es como utilizar cout
	printf("Age: ");
	scanf("%i",&edad);//scanear datos de la consola, almacenamos y especificamos el tipo de dato
	//%i y se le acompaña de la variable que guardara los datos
	printf("Name Complete: ");
	fflush(stdin);
	getline(cin, nameComplete); //leer linea completa obteniendo datos, por el metodo de entrada estandar
	fflush(stdin); //libreria se implementa con stdlib, limpia la entrada estandar de la consola
	printf("Weight: ");
	scanf("%f",&weight);
	getch();  //parte de la libreria conio realiza una pausa hasta presionar una tecla sin mostrar texto
	system("cls");//limpiamos pantalla de la consola
	printf("\tData User\n");
	printf("Age: %i\n",edad);
	cout<<"Name Complete: "<<nameComplete<<endl;
	printf("Weight: %.2f\n",weight);//especificamos con el porciento .2 la cantidad de decimales que imprimimos
	return 0;
}

//Programa que permita ingresar dos numeros y mostrar operaciones basicas con ellos
#include<iostream>
using namespace std;
int main(){
	int num1, num2;
	int resultado = 0;
	num1 = num2 = 0; //con esto le damos valor a las variables inicializandolas en cero ambas
	cout<<"Dato num1: "<<num1<<endl<<"Dato num2: "<<num2<<endl;
	cout<<"Digite nuevos datos"<<endl;
	cout<<"num1: "; cin>>num1;
	cout<<"num2: "; cin>>num2; //cin al igual que scanf permite lectura de datos y asignarlos en variables
	resultado = num1 + num2;
	printf("Resultado de la suma: %i\n", resultado);
	printf("Resultado de la suma: %i\n", num1+num2); //estas son dos formas distintas de mostrar resultados
	//en la segunda forma podemos encontrar una manera de operar sin necesidad de una variable auxiliar
	return 0;
}

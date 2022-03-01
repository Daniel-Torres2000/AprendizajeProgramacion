//Programa que permita mostrar los numeros del 1 al 100 separados por comas mediante for
//se utilizara programacion estructurada unicamente para facilitar el proceso de aprendizaje
#include<iostream>
using namespace std;
int main(){
	for(int i = 1; i <= 100; i++){
		cout<<i<<",";//mostramos el iterador i, y automaticamente separador coma para que quede lineal
	}
	//el ciclo for permite declarar la variable dentro del mismo ciclo, pero solo existe dentro del ciclo,
	//tambien la podemos declarar fuera e implementar dentro de los argumentos del ciclo
	return 0;
}

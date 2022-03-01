//elabore un programa que permita mostrar numeros impares del 100 al 1 con while
#include<iostream>
using namespace std;
int main(){
	//el ciclo while no permite declarar variable dentro de los argumentos del ciclo
	//para ello creamos un iterador externo fuera del ciclo y provocaremos aumentos o decrementos en el mismo
	int i = 100;
	while(i >= 0){
		if(i%2==1){
			cout<<i<<",";
		}
		i--;
	}
}

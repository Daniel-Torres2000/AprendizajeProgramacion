//Programa que permita mostrar una tabla de multiplicar del numero que se ingrese con ciclo do while
#include<iostream>
using namespace std;
int main(){
	int n, i;
	i = 1;
	cout<<"Digite n: "; cin>>n;
	do{
		cout<<n<<" x "<<i<<" = "<<n*i<<endl;
		i++;
	}while(i <= 10);
	//operadores logicos como < menor que, > mayor que, <= menor igual que, >= mayor igual que
	//facilitan el proceso para las condicionales estructuras logicas y de bucles o de repeticion
	return 0;
}

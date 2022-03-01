//programa que permita trabajar funciones de diferentes tipos con operaciones basicas
#include<iostream>
#include<conio.h>
int suma(int n1, int n2){
	return n1+n2;
}
int resta(int n1, int n2){
	return n1-n2;
}
int multi(int n1, int n2){
	return n1*n2;
}
float division(float n1, float n2){
	return n1/n2;
}
using namespace std;
int main(){
	int n1, n2, n3, n4;
	printf("Digite n1: "); scanf("%i",&n1); n3 = n1;
	printf("Digite n2: "); scanf("%i",&n2); n4 = n2;
	printf("Suma: %i\nResta: %i\nMultiplicacion: %i\nDivision: %f\n",suma(n1,n2),resta(n1,n2),multi(n1,n2),division(n3,n4));
	getch();
	return 0;
}

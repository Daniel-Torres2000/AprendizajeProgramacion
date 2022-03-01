////Programa que implemente tipos de datos distintos y constantes
//parte dos del algoritmo
#include<iostream>
using namespace std;
int main()
{
	int valorEntero = 10;
	float valorDecimal = 1.25;
	char valorCaracteres[] = {'D','A','N'}; //especificamos cuantos caracteres puede tener el dato en este caso 25
	double valorDecimalExtendido = 1.505484;//recibe mas decimales con precision en comparacion a float
	//tomese en cuenta que float pesa 4byte de memoria y double 8byte
	const int valorFijo = 15; //no es un valor cambiante como la variable, es un valor fijo predefinido
	cout<<valorEntero<<endl<<valorDecimal<<endl<<valorCaracteres<<endl<<valorDecimalExtendido<<endl<<valorFijo<<endl;
	return 0;
}

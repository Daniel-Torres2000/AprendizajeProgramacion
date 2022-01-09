#include<iostream>
using namespace std;
int main(){
	char name[25];
	int num1, num2;
	int result;
	cout<<"Enter a number: "; cin>>num1;
	cout<<"Enter another number: "; cin>>num2;
	result = num1+num2;
	cout<<"Result: "<<result<<endl;	
	//to print the variable in screen we have to 
	//use the std:cout command
	return 0;
}

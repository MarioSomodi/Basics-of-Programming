#include "stdafx.h"
#include <iostream>

using namespace std;

void DajSumuParnih(int nBroj) 
{
	int s = 0;
	for (int i = 1; i <= nBroj; i++)
	{
		if (i % 2 == 0)
		{
			s += i;
		}
	}
	cout << "Suma parnih brojeva je " << s << endl;
}

void DajUmnozakNeparnih(int nBroj) 
{
	int u = 1;
	for (int i = 1; i <= nBroj; i++) 
	{
		if(i % 2 != 0)
		{
			u *= i;
		}
	}
	cout << "Umnozak neparnih brojeva je " << u << endl;
}

int main()
{
	int a;
	cout << "Unesi broj do 50: ";
	cin >> a;
	if (a > 50)
	{
		cout << "Unjeli ste broj veci od 50 , unesite broj ponovno : ";
		cin >> a;
	}
	DajSumuParnih(a);
	DajUmnozakNeparnih(a);
	system("pause");
	return 0;
}


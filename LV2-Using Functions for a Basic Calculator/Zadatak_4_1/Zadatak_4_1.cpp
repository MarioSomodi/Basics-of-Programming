#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	double a, b, p;
	do 
	{
		cout << "Unesi prvi broj: ";
		cin >> a;
		cout << "Unesi drugi broj: ";
		cin >> b;
		p = (a + b) / 2;
		cout << "Prosjecna vrijednost je " << p << endl;
	} while (p > 5);
	system("pause");
	return 0;
}


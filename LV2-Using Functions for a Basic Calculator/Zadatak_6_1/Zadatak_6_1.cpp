#include "stdafx.h"
#include <iostream>

using namespace std;

int DajFaktorijel(int nBrojFaktorijela) 
{
	int f = 1;
	for (int i = 1; i <= nBrojFaktorijela; i++)
	{
		f = f * i;
	}
	return f;
}

int main()
{
	int a, b;
	cout << "Unesi cijeli broj: ";
	cin >> a;
	cout << DajFaktorijel(a) << endl;
	system("pause");
	return 0;
}


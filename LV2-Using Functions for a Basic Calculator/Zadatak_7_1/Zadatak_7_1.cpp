#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int a, f;
	int DajFaktorijel(int);
	cout << "Unesi broj: ";
	cin >> a;
	cout << "Faktorijel je " << DajFaktorijel(a) << endl;
	system("pause");
	return 0;
}

int DajFaktorijel(int nBrojFaktorijela)
{
	if (nBrojFaktorijela == 0)
	{
		return (1);
	}
	else 
	{
		return (nBrojFaktorijela * DajFaktorijel(nBrojFaktorijela - 1));
	}

}
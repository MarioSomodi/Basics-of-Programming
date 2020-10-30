#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int aPolje4a[3][3];
	int aPolje4b[3][3];
	for (int i = 0; i<3; i++)
	{
		for (int j = 0; j<3; j++)
		{
			cout << "Upisi elemnt u " << i+1 << " redku i " << j+1 << " stupcu: ";
			cin >> aPolje4a[i][j];
		}
	}
	cout << "Polje 4a" << endl;
	for (int i = 0; i<3; i++)
	{
		for (int j = 0; j<3; j++)
		{
			cout << aPolje4a[i][j] << "  ";
		}
		cout << "\n";
	}
	for (int i = 0; i < 3;i++)
	{
		for (int j = 0; j<3; j++)
		{
			aPolje4b[i][j] = aPolje4a[i][j] * aPolje4a[i][j];
		}
	}
	cout << "Polje 4b kojem je svaki element zapravo kvadrat elementa iz polja 4a" << endl;
	for (int i = 0; i<3; i++)
	{
		for (int j = 0; j<3; j++)
		{
			cout << aPolje4b[i][j] << "  ";
		}
		cout << "\n";
	}
	system("pause");
	return 0;
}


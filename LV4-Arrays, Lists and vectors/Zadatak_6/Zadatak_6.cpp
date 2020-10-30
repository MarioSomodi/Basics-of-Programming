#include "stdafx.h"
#include "iostream"

using namespace std;

void DohvatiNajmanji(int polje[10]) 
{
	int min = polje[0];
	for (int i = 0; i < 10; i++)
	{
		if (min > polje[i])
		{
			min = polje[i];
		}
	}
	cout << "Najmanji broj u polju je " << min << endl;
}

void DohvatiNajveci(int polje[10])
{
	int max = polje[0];
	for (int i = 0; i < 10; i++)
	{
		if (max < polje[i])
		{
			max = polje[i];
		}
	}
	cout << "Najveci broj u polju je " << max << endl;
}

int main()
{
	int aPolje6[10];
	for (int i = 0; i < 10; i++)
	{
		cout << "Unesi " << i + 1 << " element u polju: ";
		cin >> aPolje6[i];
	}
	DohvatiNajmanji(aPolje6);
	DohvatiNajveci(aPolje6);
	system("pause");
	return 0;
}
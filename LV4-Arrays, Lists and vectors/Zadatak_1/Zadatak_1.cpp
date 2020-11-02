#include "stdafx.h"
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	int aPolje1[15];
	fstream zadatak1("Datoteke\\Zadatak_1.txt", ios::out | ios::trunc);
	for (int i = 0; i < 15; i++) 
	{
		aPolje1[i] = i * i;
		zadatak1 << aPolje1[i] << "  ";
	}
	zadatak1.close();
	system("pause");
	return 0;
}

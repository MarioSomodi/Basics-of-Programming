#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <fstream>

using namespace std;

int main()
{
	double *aPolje2 = new double[12];	double s = 0, p;	fstream Zadatak2("C:\\Users\\fpsdr\\Desktop\\Mario_Somodi\\LV4\\OsnoveProgramiranjaLV4\\Datoteke\\Zadatak_2.txt", ios::trunc | ios::out);	for (int i = 0; i < 12; i++)	{		aPolje2[i] = pow(2, i);		Zadatak2 << aPolje2[i] << "  ";		s = s + aPolje2[i];	}	p = s / 12;	Zadatak2 << "\nProsjecna vrijednost  je " << p;	Zadatak2.close();
	delete[] aPolje2;
	system("pause");
	return 0;
}


#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string path = "C:\\Users\\fpsdr\\Desktop\\Mario_Somodi\\LV3\\OsnoveProgramiranjaLV3\\Datoteke\\ParniBrojevi.txt";
	int unosb;
	fstream parnibrojevi(path, ios::out | ios::trunc);
	cout << "Unesite broj do kojeg zelite upisati sve parne brojeve u datoteku: ";
	cin >> unosb;
	for (int i = 0; i <= unosb; i++)
	{
		if (i % 2 == 0)
		{
			parnibrojevi << i << " ";
		}
	}
	parnibrojevi.close();
	system("pause");
    return 0;
}


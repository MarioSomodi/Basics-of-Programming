#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string pathu, pathi;
	pathu = "C:\\Users\\fpsdr\\Desktop\\Mario_Somodi\\LV3\\OsnoveProgramiranjaLV3\\Datoteke\\hello.txt";
	pathi = "C:\\Users\\fpsdr\\Desktop\\Mario_Somodi\\LV3\\OsnoveProgramiranjaLV3\\Datoteke\\hello_copy.txt";
	fstream ulaz(pathu, ios::in);
	fstream izlaz(pathi, ios::out);
	char c;
	while (ulaz.get(c))
	{
		cout << c << endl;
		izlaz.put(c);
	}
	ulaz.close();
	izlaz.close();
    return 0;
}


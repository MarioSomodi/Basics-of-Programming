#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	fstream Zadatak2;
	string path = "C:\\Users\\fpsdr\\Desktop\\Mario_Somodi\\LV3\\OsnoveProgramiranjaLV3\\Datoteke\\Zadatak2.txt";
	Zadatak2.open(path, ios::in);
	if (Zadatak2) 
	{
		Zadatak2.close();
		Zadatak2.open(path, ios::out);
		Zadatak2.clear();
		Zadatak2.close();
	}
	else 
	{
		Zadatak2.close();
		Zadatak2.open(path, ios::out);
		Zadatak2.close();
	}
	system("pause");
    return 0;
}


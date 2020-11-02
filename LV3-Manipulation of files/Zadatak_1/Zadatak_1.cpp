#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string path = "Datoteke\\hello1.txt";
	ofstream hello(path, ios::app);
	string tekst;
	cout << "Unesi tekst koji zelis da bude upisan u datoteku: ";
	getline(cin, tekst);
	hello << tekst;
	hello.close();
	system("pause");
	return 0;
}

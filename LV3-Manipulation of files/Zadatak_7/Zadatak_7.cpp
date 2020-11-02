#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string path = "Datoteke\\Brojevi.txt";
	double p, unosb1, unosb2, unosb3, unosb4, unosb5;
	fstream broj(path, ios::out | ios::trunc);
	cout << "Unesite 5 brojeva: \n";
	cout << "Prvi broj: ";
	cin >> unosb1;
	cout << "Drugi broj: ";
	cin >> unosb2;
	cout << "Treci broj: ";
	cin >> unosb3;
	cout << "Cetvrti broj: ";
	cin >> unosb4;
	cout << "Peti broj: ";
	cin >> unosb5;
	p = (unosb1 + unosb2 + unosb3 + unosb4 + unosb5) / 5;
	broj << unosb1 << ", " << unosb2 << ", " << unosb3 << ", " << unosb4 << ", " << unosb5 << "\nProsjecna vrijednost je: " << p << endl;
	cout << "\nProsjecna vrijednost vasih brojeva je " << p << endl;
	broj.close();
	system("pause");
	return 0;
}

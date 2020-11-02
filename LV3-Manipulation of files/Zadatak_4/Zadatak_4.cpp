#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int DohvatiIzbornik() 
{
	int nOdabir;
	cout << "Izaberi koju datoteku zelis otvoriti: \n1....Restorani.json\n2....Knjige.xml\n3....Hello.txt"<< endl;
	cin >> nOdabir;
	return nOdabir;
}

int main()
{
	string sLine, sPath;
	switch (DohvatiIzbornik())
	{
		case 1: 
		{
			sPath = "Datoteke\\restorani.json";
			fstream oDatoteka(sPath, ios::in);
			if (oDatoteka) 
			{
				while (getline(oDatoteka, sLine))
				{
					cout << sLine << '\n';
				}
			}
			else
			{
				cout << "Greska pri otvaranju datoteke!" << endl;
			}
			oDatoteka.close();
			break;
		}
		case 2:
		{
			sPath = "Datoteke\\knjige.xml";
			fstream oDatoteka(sPath, ios::in);
			if (oDatoteka)
			{
				while (getline(oDatoteka, sLine))
				{
					cout << sLine << '\n';
				}
			}
			else
			{
				cout << "Greska pri otvaranju datoteke!" << endl;
			}
			oDatoteka.close();
			break;
		}
		case 3:
		{
			sPath = "Datoteke\\hello.txt";
			fstream oDatoteka(sPath, ios::in);
			if (oDatoteka)
			{
				while (getline(oDatoteka, sLine))
				{
					cout << sLine << '\n';
				}
			}
			else 
			{
				cout << "Greska pri otvaranju datoteke!" << endl;
			}
			oDatoteka.close();
			break;
		}
		default: 
		{
			cout << "Odabrali ste datoteku koja nepostoji!" << endl;
			break;
		}
		}
	system("pause");
    return 0;
}

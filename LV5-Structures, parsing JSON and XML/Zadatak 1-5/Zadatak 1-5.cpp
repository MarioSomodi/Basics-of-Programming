#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>

using namespace std;

//Zadatak 1.
struct Artikal 
{
	string sifra;
	string naziv;
	string opis;
	double cijena;
	Artikal(string s, string n, string o, double c) 
	{
		sifra = s;
		naziv = n;
		opis = o;
		cijena = c;
	}
};
//Kraj 1. zadatka

//4. Zadatak
void IspisArtikala(vector<Artikal> lista) 
{
	//Zadatak 3.
	for (int i = 0; i < lista.size(); i++) 
	{
		cout << "Sifra: " << lista[i].sifra << endl;
		cout << "Naziv: " << lista[i].naziv << endl;
		cout << "Opis: " << lista[i].opis << endl;
		cout << "Cijena: " << lista[i].cijena << endl;
	}
	//Kraj 3. zadatka
}
//Kraj 4. zadatka

//5. Zadatak
void PretragaArtikala(vector<Artikal> lista)
{
	string unospretrage;
	cout << "Unesite naziv artikla o kojem zelite vise informacija: ";
	getline(cin, unospretrage);
	bool naden = false;
	for (int i = 0; i < lista.size(); i++) 
	{
		if (unospretrage == lista[i].naziv)
		{
			cout << "Sifra: " << lista[i].sifra << endl;
			cout << "Opis: " << lista[i].opis << endl;
			cout << "Cijena: " << lista[i].cijena << endl;
			naden = true;
		}
	}
	if (naden == false) 
	{
		cout << "Artikal ne postoji!" << endl;
	}
}
//Kraj 5. Zadatka

int main()
{
	//Zadatak 2.
	vector<Artikal> vArtikli;
	Artikal A1("kwm2345", "Racunalo", "Ovo je vrhunsko racunalo", 150.99);
	Artikal A2("kwm2575", "Konzola PS3", "Ovo je playstation konzola 3 generacije", 350.99);
	Artikal A3("kwm2505", "Konzola PS4", "Ovo je playstation konzola 4 generacije", 450.99);
	Artikal A4("kwm2875", "Mis", "Racunalni mis", 50.99);
	Artikal A5("kwm2075", "Tipkovnica", "Mehanicka racunalna tipkovnica", 190.99);
	vArtikli.push_back(A1);
	vArtikli.push_back(A2);
	vArtikli.push_back(A3);
	vArtikli.push_back(A4);
	vArtikli.push_back(A5);
	//Kraj 2. Zadatka

	IspisArtikala(vArtikli);
	PretragaArtikala(vArtikli);
	system("pause");
	return 0;
}


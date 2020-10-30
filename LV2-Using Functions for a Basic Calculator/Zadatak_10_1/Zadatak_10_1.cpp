#include "stdafx.h"
#include <iostream>

using namespace std;

int DohvatiIzbornik()
{
	int a;
	cout << "Izaberi broj operacije koju ces koristiti : \n1 - zbrajanje\n2 - oduzimanje\n3 - mnozenje\n4 - djeljenje" << endl;
	cin >> a;
	return a;
}

double Zbrajanje(double nPrviBroj, double nDrugiBroj)
{
	long z = nPrviBroj + nDrugiBroj;
	return z;
}

double Oduzimanje(double nPrviBroj, double nDrugiBroj)
{
	double r = nPrviBroj - nDrugiBroj;
	return r;
}

double Mnozenje(double nPrviBroj, double nDrugiBroj)
{
	double u = nPrviBroj * nDrugiBroj;
	return u;
}

double Djeljenje(double nPrviBroj, double nDrugiBroj)
{
	double k = nPrviBroj / nDrugiBroj;
	return k;
}

void IzvrsiOperaciju(int IDOperacije, double nPrviBroj, double nDrugiBroj)
{
	switch (IDOperacije) 
	{
	case 1: 
	{
		cout << "Zbroj vasa dva broja je " << Zbrajanje(nPrviBroj, nDrugiBroj) << endl;
		break;
	}
	case 2:
	{
		cout << "Razlika vasa dva broja je " << Oduzimanje(nPrviBroj, nDrugiBroj) << endl;
		break;
	}
	case 3:
	{
		cout << "Umnozak vasa dva broja je " << Mnozenje(nPrviBroj, nDrugiBroj) << endl;
		break;
	}
	case 4:
	{
		cout << "Kolicnik vasa dva broja je " << Djeljenje(nPrviBroj, nDrugiBroj) << endl;
		break;
	}
	default:
	{
		cout << "Operator koji ste izabrali nije podrzan" << endl;
		break;
	}
	}
}

int main()
{
	double a, b;
	cout << "Unesi prvi broj: ";
	cin >> a;
	cout << "Unesi drugi broj: ";
	cin >> b;
	IzvrsiOperaciju(DohvatiIzbornik(), a, b);
	system("pause");
    return 0;
}
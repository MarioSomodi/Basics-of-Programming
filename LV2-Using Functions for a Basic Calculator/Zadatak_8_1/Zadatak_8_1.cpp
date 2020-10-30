#include "stdafx.h"
#include <iostream>

using namespace std;

void DajPovrsinu(int nStranicaA, int nStranicaB)
{
	int p = nStranicaA * nStranicaB;
	cout << p << endl;
}

int main()
{
	int a, b;
	cout << "Unesi duzinu stranice a: ";
	cin >> a;
	cout << "Unesi duzinu stranice b: ";
	cin >> b;
	DajPovrsinu(a, b);
	system("pause");
    return 0;
}


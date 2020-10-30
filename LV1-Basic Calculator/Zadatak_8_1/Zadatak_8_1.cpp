#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	cout << "Unesite jedan broj : ";
	int a;
	cin >> a;
	switch (a) {
	case 1:
	{
		cout << "Jedan" << endl;
		break;
	}
		break;
	case 2:
	{
		cout << "Dva" << endl;
		break;
	}
	case 3:
	{
		cout << "Tri" << endl;
		break;
	}
	case 4:
	{
		cout << "Cetiri" << endl;
		break;
	}
	case 5:
	{
		cout << "Pet" << endl;
		break;
	}
	default:
	{
		cout << "Nepoznat broj!" << endl;
		break;
	}
	}

	system("Pause");
    return 0;
}


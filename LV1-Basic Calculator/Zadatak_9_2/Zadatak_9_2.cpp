#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int a = 34 + 37 * (23 - 8) - 22 * 23;
	switch (a)
	{
	case 0:
	{
		cout << "Nula" << endl;
		break;
	}
	case 83:
	{
		cout << "OsamdesetTri" << endl;
		break;
	}
	default:
	{
		cout << "Nepoznat" << endl;
	}
	}
	system("Pause");
    return 0;
}


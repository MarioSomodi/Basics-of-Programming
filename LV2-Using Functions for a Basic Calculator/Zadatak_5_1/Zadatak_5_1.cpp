#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int i = 1;
	int f = 1;
	do
	{
		cout << "i = " << i << endl;
		f = f * i;
		cout << "Faktorijel je " << f << endl;
		i++;
	} while (i <= 10);
	system("pause");
    return 0;
}


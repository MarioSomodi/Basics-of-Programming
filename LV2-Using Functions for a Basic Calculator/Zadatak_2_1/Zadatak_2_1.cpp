#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int f = 1;
	for (int i = 1; i <= 10; i++) 
	{
		cout << "i = " << i << endl;
		f = f * i;
		cout << "Faktorijel je " << f << endl;
	}
	system("pause");
    return 0;
}


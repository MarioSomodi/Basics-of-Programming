#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int i = 1;
	int f = 1;
	while (i <= 10) 
	{
		cout << "i = " << i << endl;
		f = f * i;
		cout << "Faktorijel je " << f << endl;
		i++;
	}
	system("pause");
    return 0;
}


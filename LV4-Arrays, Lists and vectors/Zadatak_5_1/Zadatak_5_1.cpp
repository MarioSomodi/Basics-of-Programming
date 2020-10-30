#include "stdafx.h"
#include <iostream>

using namespace std;

void ZbrojiPolja(int polje1[3][4], int polje2[3][4])
{
	int s;
	for (int i = 0; i<3; i++) 
	{
		for (int j = 0; j<4; j++)
		{
			s = polje1[i][j] + polje2[i][j];
			cout << s << "  ";
		}
		cout << "\n";
	}
}

int main()
{
	int aPolje5a[3][4]{ {1, 2, 3, 4}, {4, 5, 6, 7}, {7, 8, 9, 10} };
	int aPolje5b[3][4]{ {11, 12, 23, 12}, {12, 45, 66 ,87}, {23, 45, 77, 33} };
	ZbrojiPolja(aPolje5a, aPolje5b);
	system("pause");
    return 0;
}


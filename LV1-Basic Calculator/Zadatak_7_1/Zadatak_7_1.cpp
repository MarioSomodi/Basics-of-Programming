#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int a;
	cout << "Unesi broj : ";
	cin >> a;
	if (a % 2 == 0) 
	{
		cout << "Paran" << endl;
	} 
	else 
	{
		cout << "Neparan" << endl;
	}
	system("Pause");
    return 0;
}


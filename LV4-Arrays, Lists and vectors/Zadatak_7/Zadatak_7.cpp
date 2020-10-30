#include "stdafx.h"
#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int i = 0;
	vector<int> z;
	while (i != 50) 
	{
		cin >> i;
		z.push_back(i);
		cout << "Velicina vektora je "<< z.size() << endl;
	}
	cout << "Unjeli ste broj 50" << endl;
	z.clear();
	cout << "Velicina vektora je " << z.size() << endl;
	system("pause");
	return 0;
}
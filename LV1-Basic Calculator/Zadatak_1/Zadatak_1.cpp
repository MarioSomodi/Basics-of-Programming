#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

int main()
{
	string name;
	cout << "Enter your first name : ";
	cin >> name;
	cout << "Hello " + name + " have a nice day!!" << endl;
	system("pause");
	return 0;
}
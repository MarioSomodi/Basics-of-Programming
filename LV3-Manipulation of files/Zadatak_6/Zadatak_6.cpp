#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>

using namespace std;

int main()
{
	string sLine, temp;
	int found;
	string path1 = "Datoteke\\ParniBrojevi.txt";
	string path2 = "Datoteke\\NeparniBrojevi.txt";
	fstream parniBrojevi(path1, ios::in);
	fstream neparnibrojevi(path2, ios::out | ios::trunc);
	neparnibrojevi.close();
	if (parniBrojevi.is_open())
	{
		while (getline(parniBrojevi, sLine))
		{
			stringstream ss;
			ss << sLine;

			while (!ss.eof()) {

				ss >> temp;

				if (stringstream(temp) >> found)
				{
					int neparnibroj = 0;
					neparnibroj = found + 1;
					fstream neparnibrojevi(path2, ios::out | ios::app);
					neparnibrojevi << neparnibroj << " ";
					neparnibrojevi.close();
				}
				temp = "";
			}
		}
		parniBrojevi.close();
	}
	else
	{
		cout << "Greska pri otvaranju datoteke";
	}
	system("pause");
	return 0;
}

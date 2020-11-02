#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
#include <ctime>

using namespace std;

string GetDateTime()
{
	string sDateTime;
	time_t t;
	t = time(NULL);
	tm tlm;
	localtime_s(&tlm, &t);
	sDateTime = to_string(tlm.tm_year + 1900)
		+ "-"
		+ to_string(tlm.tm_mon + 1)
		+ "-"
		+ to_string(tlm.tm_mday)
		+ " "
		+ to_string(tlm.tm_hour)
		+ ":"
		+ to_string(tlm.tm_min)
		+ ":"
		+ to_string(tlm.tm_sec);
	return sDateTime;
}

int main()
{
	string path = "Datoteke\\Logovi.log";
	fstream Logovi(path, ios::app | ios::out);
	Logovi << "Program pokrenut: " << GetDateTime() << endl;
	system("pause");
	Logovi << "Program zatvoren: " << GetDateTime() << endl;
	Logovi.close();
    return 0;
}

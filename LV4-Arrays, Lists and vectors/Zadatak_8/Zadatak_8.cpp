#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector<int> x;
	int y;
	while (x.size() != 10) 
	{
		cout << "Unesi broj: ";
		cin >> y;
		if (y % 2 != 0) 
		{
			x.push_back(y);
		}
	}

	for (int i = 0; i < x.size(); i++) 
	{
		cout << x[i] << " ";
	}

	system("pause");
}
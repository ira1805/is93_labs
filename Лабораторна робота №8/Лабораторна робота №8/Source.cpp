#include<iostream>
#include<string>
using namespace std;
bool FindLitteral(string s)//Method for find litteral
{
	bool flag = false;
	for (int i = 0; i < s.length(); i++)
	{
		if (isalpha(s[i])==2)
		{
			flag = true;
			break;
		}
	}
	return flag;
}
int main()
{
	cout << "Samilenko Oleksandr, IS-93\n";
	string s;
	cout << "String: ";
	getline(cin, s);
	bool (*messag) (string);//Add refer with parapetrs of string
	messag = FindLitteral;//Add refer of method to value
	if (messag(s) == true)//If string has a litteral -> true
	{
		cout << "This string has a literal " << endl;
	}
	else
	{
		cout << "This string has not literal" << endl;//If string has not a litteral ->false
	}
	system("pause");
	return 0;
}
#include <iostream>
#include <string>

using namespace std;

int cacl(string s) 
{
	int count = 0;
	for (int i = 0; i < s.length(); i++) 
	{
	if(isupper(s[i])) count++;
	}
	return count;
}

int main() 
{
	string s = "";
	cout << "Enter string" << endl;
	cin >> s;
	int(*bigletters)(string s) = cacl;
	cout << "In your string " <<(*bigletters)(s)<<" big letter"<< endl;
	return 0;
}

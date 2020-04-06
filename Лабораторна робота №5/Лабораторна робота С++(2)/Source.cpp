#include<iostream>
#include"Strings.h"
#include<vector>
using namespace std;

int main()
{
    cout << "Samilenko Oleksandr IS-93\n";
    cout<<"Input string:\n";
    vector<char> s2;
    char c=' ';
    while (c != '\n')
    {
        c = getchar();
        if (c != '\n')
        {
            s2.push_back(c);
        }
    }
    int len = s2.size();
    vector<char> s;
    for (int j = 0; j < len; j++)
    {
        s.push_back(s2[j]);
    }
    for (int j = 0; j <len; j++)
    {
        cout << s[j];
    }
    cout << endl;
    cout<<"Old lenght "<<s2.size()<<"\n";
    Strings *obj1 = new Symbols(s);
    s = obj1->Change();
    for (int i = 0; i < obj1->length(s); i++)
    {
        cout << s[i];
    }
    cout << endl;
   cout<<"New lenght "<<obj1->length(s)<<"\n";
    obj1 = new Noumbers(s);
    s = obj1->Change();
    for (int i = 0; i < obj1->length(s); i++)
    {
        cout << s[i];
    }
    cout << endl;
    cout<<"New lenght "<<obj1->length(s)<<"\n";
	system("pause");
	return 0;
}
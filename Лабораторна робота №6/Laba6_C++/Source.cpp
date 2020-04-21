#include<iostream>
#include"ExpressionClassC.h"
#include<iomanip>

using namespace std;
int main()
{
    cout << "Samilenko Oleksandr IS-93\n";
    ExpressionClassC *obj[5];// Make arrg out objects
    obj[0] = new ExpressionClassC(1, 2, 3, 20);
    obj[1] = new ExpressionClassC(5, 2, 3, 2);
    obj[2] = new ExpressionClassC(4, 2, 5, 10);
    obj[3] = new ExpressionClassC(1, 41, 12, 121);
    obj[4] = new ExpressionClassC(4, 13, 3, 15);
    for (int i = 0; i < 5; i++)
    {
        cout << "Value" << i + 1 << " = "<<fixed<<setprecision(3)<< obj[i]->Value() << endl;;//Output value each object
    }
	system("pause");
	return 0;
}
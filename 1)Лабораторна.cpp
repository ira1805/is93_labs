#include <iostream>

using namespace std;

//равность
int func1(int x, int x1) {
    int *p;
    int *p1;
    p = &x;
    p1 = &x1;
    return *p & *p1;
}
int main(int argc, char* argv[])
{
    int x, x1, y, y1;
    cout << "Введите x" << endl;
    cin >> x;
    cout << "Введите x1" << endl;
    cin >> x1;
   
    
    cout << func1(48, 48)<<endl;
    cout << func1(69, 78)<<endl;
    cout << func1(24, 25)<<endl;
    cout << func1(x, x1)<<endl;
    
    cout<<endl;
    return 0;
}
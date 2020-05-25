#include <iostream>
#include "CharList.hpp"
using namespace std;

int main()
{
    cout << "Baranov Dmytro IS-93\n\n\n";
    node* list = initList("asv!skd!akka");
    cout << " input list content:  " << outputList() << "\n index of first <!>:  " << findFirst('!') << "\n";
    removeAll('a');
    cout << " list content after removing all <a>:  " << outputList() << "\n\n";
    system("pause");
}
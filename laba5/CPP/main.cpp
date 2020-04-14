#include <iostream>
#include <vector>
#include "1Task/DerirativeTrapezium.h"
#include "2Task/BaseString.h"
#include "2Task/DerirativeSymbols.h"
#include "2Task/DerirativeNumerals.h"

using namespace std;

string printVectorVectorInt(vector<vector<int>> userVector){
    string vectorString = "[";
    for (int i = 0; i < userVector.size(); i++){
        vectorString += "[";
        vectorString += to_string(userVector[i][0]);
        vectorString += ", ";
        vectorString += to_string(userVector[i][1]);
        vectorString += i == userVector.size() - 1 ? "]" : "],";
    }
    vectorString += "]";
    return vectorString;
}

int main() {
    // 1 task
    cout << "IS-93 Kravchenko Olena, 12 variant" << endl;
    vector<vector<int>> userCoordinates1 = {{-3, 4},{2, 4},{4, -1},{-5, -1}};
    vector<vector<int>> userCoordinates2 = {{4, 2},{26, 1},{6, -4},{-4, -4}};  // Wrong coordinates test(no parallel sides)
    vector<vector<int>> userCoordinates3 = {{2, 2},{2, -3},{-3, -3},{-3, 3}};
    Trapezium *userTrapezium1 = new Trapezium(userCoordinates1);
    Trapezium *userTrapezium3 = new Trapezium(userCoordinates3);

    try{
        Trapezium *userTrapezium2 = new Trapezium(userCoordinates2);  // Wrong vertices order test
    } catch (const char* msg) {
        cerr << msg << endl;
    }
    try{
        userTrapezium1->LengthOfSide(1,3);  // Wrong vertices order test
    } catch (const char* msg) {
        cerr << msg << endl;
    }
    cout << "Area of the first trapezium: " << round(userTrapezium1->Area()) << endl;
    cout << "Perimeter of the third trapezium: " << userTrapezium3->Perimeter() << endl;
    cout << "\tTrapezium 3 \n"<< printVectorVectorInt(userTrapezium3->GetCoordinates()) << endl;

    // 2 task
    BaseString *userString1 = new Numeral("hello World!");
    Numeral *userNumeral = (Numeral*)userString1;
    BaseString *userString2 = new Symbols("knock-knock-knock");
    Symbols *userSymbol = (Symbols*)userString2;
    cout << "Increasing userNumeral variable..." << endl;
    userNumeral->Increase();
    cout << userNumeral->GetString() << endl;
    cout << userSymbol->GetString() << endl;
    cout << "Increasing userSymbol variable..." << endl;
    userSymbol->Increase();
    cout << userSymbol->GetString() << endl;


}
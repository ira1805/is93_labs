#include <iostream>
#include "Expression/Expression.h"
#include "Rectangle/EditedRectangle.h"
using namespace std;

int main() {
    cout << "IS-93 Kravchenko Olena, 12 variant" << endl;
    // Expression
    vector<Expression> objectArray = {
            Expression(1.0, 26.0, 4.0, 2.0),  // No errors
    };

    try {
        objectArray.push_back(Expression(8.0, 1.0, 5.0, 10.0));// 4*b-c < 0
    } catch (const char* msg) {
        cerr << msg << endl;
    }
    try {
        objectArray.push_back(Expression(5.0, 4.0, 2.0, 0.0));  // d = 0
    } catch (const char* msg) {
        cerr << msg << endl;
    }
    try {
        objectArray.push_back(Expression(3.0, 5.0, 10.0, -2.5));  // b+c/d-1 = 0
    } catch (const char* msg) {
        cerr << msg << endl;
    }

    for (int i = 0; i < objectArray.size(); i++){
        cout << "Expression Value: " << objectArray[i].GetExpressionValue() << endl;
    }

    // Overloading operators
    EditedRectangle Q1;  // Default constructor
    EditedRectangle Q2 = EditedRectangle({{-1., 1.},{3., 1.},{3., -2.},{-1., -2.}});  // Parameters constructor

    try {
        EditedRectangle Q3 = EditedRectangle(EditedRectangle({{-4., 7.},{5., 7.},{5., -5.}}));  // Copy constructor with wrong amount of vertices
    } catch (const char* msg) {
        cerr << msg << endl;
    }

    try {
        EditedRectangle Q4 = EditedRectangle({{-1., 4.},{8., 1.},{3., -6.},{-18., -2.}});  // Wrong coordinates
    } catch (const char* msg) {
        cerr << msg << endl;
    }

    try {
        Q2 = Q2/0.0;
    } catch (const char* msg) {
        cerr << msg << endl;
    }
}

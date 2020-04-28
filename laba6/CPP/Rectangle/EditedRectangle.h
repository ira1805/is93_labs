#ifndef LABA6_EDITEDRECTANGLE_H
#define LABA6_EDITEDRECTANGLE_H
#include <vector>
#include <cmath>

using namespace std;


class EditedRectangle {
private: vector<vector<float>> coordinates;  // Coordinates of all vertices of the rectangle

    bool isPerpendicular(vector<float> vector1, vector<float> vector2);  // Perpendicularity check using scalar product
public:
    EditedRectangle(); // Default constructor
    EditedRectangle(vector<vector<float>> coordinates);  // Constructor with parameters
    EditedRectangle(const EditedRectangle &objectToCopy);  // Copy constructor
    float Perimeter();  // Perimeter of the rectangle
    float Area();  // Area of the rectangle
    vector<float> getCoordTopLeft();  // Getter of top left vertex of the rectangle
    vector<float> getCoordTopRight();  // Getter of top right vertex of the rectangle
    vector<float> getCoordBottomRight();  // Getter of bottom right vertex of the rectangle
    vector<float> getCoordBottomLeft();  // Getter of bottom left vertex of the rectangle
    EditedRectangle operator -(EditedRectangle &subtrahend);  // Overloading operator "-"
    EditedRectangle operator /(float factor);  // Overloading operator "/"
};


#endif //LABA6_EDITEDRECTANGLE_H

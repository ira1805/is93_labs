#include "DerirativeTrapezium.h"

Trapezium::Trapezium(vector<vector<int>> userCoordinates) : BaseFigure(std::move(userCoordinates), 4, "trapezium") {}  // Constructor with parameters for trapezium

double Trapezium::Perimeter() {  // Perimeter of the trapezium
    return LengthOfSide(1, 2) + LengthOfSide(2, 3) + LengthOfSide(3, 4) + LengthOfSide(4, 1);
}

double Trapezium::Area() {
    double top = LengthOfSide(1, 2);
    double bottom = LengthOfSide(3, 4);
    double left = LengthOfSide(4,1);
    double right = LengthOfSide(2,3);
    double temp = (pow((top-bottom),2) + pow(left,2) - pow(right,2))/(2*(top-bottom));  // ((a-b)^2 + c^2 - d^2)/2(a - b);
    double height = sqrt(pow(left, 2) - pow(temp, 2));  // sqrt(c^2 - temp^2)
    return round((((top+bottom)*height)/2)*1000) / 1000;  //(a+b)*height/2
}

vector<vector<int>> Trapezium::GetCoordinates() {
    return this->coordinates;
}

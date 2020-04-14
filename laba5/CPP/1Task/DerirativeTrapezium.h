#ifndef LABA5_DERIRATIVETRAPEZIUM_H
#define LABA5_DERIRATIVETRAPEZIUM_H
#include "BaseFigure.h"
#include <utility>

class Trapezium : public BaseFigure {
public:
    Trapezium(vector<vector<int>> userCoordinates);  // Constructor with parameters for trapezium
    double Perimeter();  // Perimeter of the trapezium
    double Area();  // Area of the trapezium
    vector<vector<int>> GetCoordinates();
};

#endif //LABA5_DERIRATIVETRAPEZIUM_H

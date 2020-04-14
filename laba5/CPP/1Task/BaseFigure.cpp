#include "BaseFigure.h"

bool BaseFigure::isParallel(int vertex1, int vertex2, int vertex3, int vertex4, vector<vector<int>> userCoord) {
    vector<int> side1 = {userCoord[vertex2][0] - userCoord[vertex1][0],
                         userCoord[vertex2][1] - userCoord[vertex1][1]};
    vector<int>side2 = {userCoord[vertex4][0] - userCoord[vertex3][0],
                        userCoord[vertex4][1] - userCoord[vertex3][1]};
    return side1[0]*side2[1] == side1[1]*side2[0];
}

BaseFigure::BaseFigure(vector<vector<int>> userCoordinates, int amountOfVertices, string typeOfFigure = "") {
    if (amountOfVertices == userCoordinates.size()) {  // Figure has specific amount of vertices
        if (userCoordinates[0].size() == 2){  // Figure has 2 coordinates - x and y
            if (typeOfFigure == "trapezium") {
                if (isParallel(0,1,2,3,userCoordinates) && !(isParallel(0,3,1,2,userCoordinates))){  // 2 parallel and 2 non-parallel sides
                    this->coordinates = userCoordinates;

                } else {throw "Wrong vertices order or no parallel sides";};

            } else {this->coordinates = userCoordinates;}

        } else {throw "Wrong amount of coordinates";}

    } else {throw "Wrong amount of vertices";}
}

double BaseFigure::LengthOfSide(int vertex1, int vertex2) {
    double length = 0.0;
    if (vertex1 > 0 && vertex2 > 0 && (fabs(vertex1 - vertex2) == 1 || (vertex1 == 1 && vertex2 == this->coordinates.size()) || (vertex2 == 1 && vertex1 == this->coordinates.size()))){  // Check values of vertices
        length = sqrt(pow((this->coordinates[vertex1 - 1][0] - this->coordinates[vertex2 - 1][0]), 2) + pow((this->coordinates[vertex1 - 1][1] - this->coordinates[vertex2-1][1]), 2));

    } else {throw "Wrong vertices order";}

    return round(length*1000) / 1000;
}

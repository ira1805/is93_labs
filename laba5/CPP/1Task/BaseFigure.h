#ifndef LABA5_BASEFIGURE_H
#define LABA5_BASEFIGURE_H
#include <vector>
#include <cmath>
#include <string>
using namespace std;

class BaseFigure {
protected:
vector<vector<int>> coordinates;  // Array with coordinates of vertices
private:
    bool isParallel(int vertex1, int vertex2, int vertex3, int vertex4, vector<vector<int>> userCoord);  // Parallelism check
public:
    BaseFigure(vector<vector<int>> userCoordinates, int amountOfVertices, string typeOfFigure); // Constructor with parameters for 2D figure
    double LengthOfSide(int vertex1, int vertex2);  // User picks 2 vertices and if they are right, method returns length of the side
};


#endif //LABA5_BASEFIGURE_H

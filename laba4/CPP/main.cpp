#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

class Rectangle{
private: vector<vector<float>> coordinates;  // Coordinates of all vertices of the rectangle

    bool isPerpendicular(vector<float> vector1, vector<float> vector2){  // Perpendicularity check using scalar product
        return (vector1[0]*vector2[0])+(vector1[1]*vector2[1]) == 0;
    }

public:
    Rectangle(){  // Default constructor
        coordinates = {
                {0,0},
                {0,0},
                {0,0},
                {0,0}
        };
    }

    Rectangle(vector<vector<float>> coordinates){  // Constructor with parameters
        vector<float> line1 = {
                    coordinates[1][0]-coordinates[0][0],
                    coordinates[1][1]-coordinates[0][1]};
        vector<float> line2 = {
                coordinates[2][0]-coordinates[1][0],
                coordinates[2][1]-coordinates[1][1]};
        vector<float> line3 = {
                coordinates[3][0]-coordinates[2][0],
                coordinates[3][1]-coordinates[2][1]};
        vector<float> line4 = {
                coordinates[0][0]-coordinates[3][0],
                coordinates[0][1]-coordinates[3][1]};
        if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
        {
            this->coordinates = move(coordinates);  // We use "move" to copy content of coordinates
        } else {
            cout << "Wrong coordinates, your shape isn't a rectangle" << endl;
        }
    }

    Rectangle(const Rectangle &objectToCopy){  // Copy constructor
        vector<float> line1 = {
                objectToCopy.coordinates[1][0]-objectToCopy.coordinates[0][0],
                objectToCopy.coordinates[1][1]-objectToCopy.coordinates[0][1]};
        vector<float> line2 = {
                objectToCopy.coordinates[2][0]-objectToCopy.coordinates[1][0],
                objectToCopy.coordinates[2][1]-objectToCopy.coordinates[1][1]};
        vector<float> line3 = {
                objectToCopy.coordinates[3][0]-objectToCopy.coordinates[2][0],
                objectToCopy.coordinates[3][1]-objectToCopy.coordinates[2][1]};
        vector<float> line4 = {
                objectToCopy.coordinates[0][0]-objectToCopy.coordinates[3][0],
                objectToCopy.coordinates[0][1]-objectToCopy.coordinates[3][1]};
        if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
        {
            this->coordinates = objectToCopy.coordinates;  // We use "move" to copy content of coordinates
        } else {
            cout << "Wrong coordinates, your shape isn't a rectangle" << endl;
        }
    }

    float Perimeter(){  // Perimeter of the rectangle
        return round(2 * ((coordinates[1][0] - coordinates[0][0]) + (coordinates[1][1] - coordinates[2][1])));
    }

    float Area(){  // Area of the rectangle
        return round((coordinates[1][0] - coordinates[0][0]) * (coordinates[1][1] - coordinates[2][1]));
    }

    vector<float> getCoordTopLeft(){  // Getter of top left vertex of the rectangle
        return this->coordinates[0];
    }
    vector<float> getCoordTopRight(){  // Getter of top right vertex of the rectangle
        return this->coordinates[1];
    }
    vector<float> getCoordBottomRight(){  // Getter of bottom right vertex of the rectangle
        return this->coordinates[2];
    }
    vector<float> getCoordBottomLeft(){  // Getter of bottom left vertex of the rectangle
        return this->coordinates[3];
    }

    Rectangle operator - (const Rectangle &subtrahend){  // Overloading operator "-"
        Rectangle difference;
        for (int i = 0; i < 4; i++)  // Loop for each coordinate
        {
            difference.coordinates[i][0] = coordinates[i][0] - subtrahend.coordinates[i][0];
            difference.coordinates[i][1] = coordinates[i][1] - subtrahend.coordinates[i][1];
        }
        return difference;
    }

    Rectangle operator / (float factor){  // Overloading operator "/"
        Rectangle product;
        for (int i = 0; i < 4; i++){  // Loop for each coordinate
            product.coordinates[i][0] = this->coordinates[i][0] / factor;
            product.coordinates[i][1] = this->coordinates[i][1] / factor;
        }
        return product;
    }
};

int main() {
    cout << "IS-93 Kravchenko Olena, 12 variant" << endl;
    Rectangle Q1;  // Default constructor
    Rectangle Q2 = Rectangle({{-1., 1.},{3., 1.},{3., -2.},{-1., -2.}});  // Parameters constructor
    cout <<"Area of Q2: "<< Q2.Area() << endl;
    Rectangle Q3 = Rectangle(Rectangle({{-4., 7.},{5., 7.},{5., -5.},{-4., -5.}}));  // Copy constructor
    printf("Coordinates of top right and bottom left vertices of Q3: %.2f, %.2f and %.2f, %.2f", Q3.getCoordTopRight()[0], Q3.getCoordTopRight()[1], Q3.getCoordBottomLeft()[0], Q3.getCoordBottomLeft()[1]);
    cout <<"\nPerimeter of Q3: "<<Q3.Perimeter()<< endl;

    Rectangle Q4 = Rectangle({{-1., 4.},{8., 1.},{3., -6.},{-18., -2.}});

    Q1 = Rectangle(Q3 - Q2);
    cout <<"\n\t\tQ1"<<endl;
    printf("Top left vertex: %.2f, %.2f", Q1.getCoordTopLeft()[0], Q1.getCoordTopLeft()[1]);
    printf("\nTop right vertex: %.2f, %.2f", Q1.getCoordTopRight()[0], Q1.getCoordTopRight()[1]);
    printf("\nBottom right vertex: %.2f, %.2f", Q1.getCoordBottomRight()[0], Q1.getCoordBottomRight()[1]);
    printf("\nBottom left vertex: %.2f, %.2f", Q1.getCoordBottomLeft()[0], Q1.getCoordBottomLeft()[1]);

    Q1 = Q1 / 2.;  // Q2 = Q2/2
    cout <<"\n\t\tQ1"<<endl;
    printf("Top left vertex: %.2f, %.2f", Q1.getCoordTopLeft()[0], Q1.getCoordTopLeft()[1]);
    printf("\nTop right vertex: %.2f, %.2f", Q1.getCoordTopRight()[0], Q1.getCoordTopRight()[1]);
    printf("\nBottom right vertex: %.2f, %.2f", Q1.getCoordBottomRight()[0], Q1.getCoordBottomRight()[1]);
    printf("\nBottom left vertex: %.2f, %.2f", Q1.getCoordBottomLeft()[0], Q1.getCoordBottomLeft()[1]);

}

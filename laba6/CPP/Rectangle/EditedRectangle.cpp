#include "EditedRectangle.h"

bool EditedRectangle::isPerpendicular(vector<float> vector1, vector<float> vector2) {
    return (vector1[0]*vector2[0])+(vector1[1]*vector2[1]) == 0;
}

EditedRectangle::EditedRectangle() {
    this->coordinates = {
            {0,0},
            {0,0},
            {0,0},
            {0,0}
    };
}

EditedRectangle::EditedRectangle(vector<vector<float>> coordinates) {
    if (coordinates.size() == 4 && coordinates[0].size() == 2){  // New condition
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
            //cout << "Wrong coordinates, your shape isn't a rectangle" << endl;  // Old code
            throw "Wrong coordinates, your shape isn't a rectangle";  // New code
        }
    } else {
        throw "Amount of vertices and/or coordinates is wrong";
    }
}

EditedRectangle::EditedRectangle(const EditedRectangle &objectToCopy) {
    if ( objectToCopy.coordinates.size() == 4 &&  objectToCopy.coordinates[0].size() == 2){  // New condition
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
            //cout << "Wrong coordinates, your shape isn't a rectangle" << endl;  // Old code
            throw "Wrong coordinates, your shape isn't a rectangle";  // New code
        }
    } else {
        throw "Amount of lines and/or coordinates is wrong";
    }
}

float EditedRectangle::Perimeter(){  // Perimeter of the rectangle
    return round(2 * ((this->coordinates[1][0] - this->coordinates[0][0]) + (this->coordinates[1][1] - this->coordinates[2][1])));
}

float EditedRectangle::Area(){  // Area of the rectangle
    return round((this->coordinates[1][0] - this->coordinates[0][0]) * (this->coordinates[1][1] - this->coordinates[2][1]));
}

vector<float> EditedRectangle::getCoordTopLeft(){  // Getter of top left vertex of the rectangle
    return this->coordinates[0];
}
vector<float> EditedRectangle::getCoordTopRight(){  // Getter of top right vertex of the rectangle
    return this->coordinates[1];
}
vector<float> EditedRectangle::getCoordBottomRight(){  // Getter of bottom right vertex of the rectangle
    return this->coordinates[2];
}
vector<float> EditedRectangle::getCoordBottomLeft(){  // Getter of bottom left vertex of the rectangle
    return this->coordinates[3];
}

EditedRectangle EditedRectangle::operator - (EditedRectangle &subtrahend){  // Overloading operator "-"
    EditedRectangle difference;
    for (int i = 0; i < 4; i++)  // Loop for each coordinate
    {
        difference.coordinates[i][0] = coordinates[i][0] - subtrahend.coordinates[i][0];
        difference.coordinates[i][1] = coordinates[i][1] - subtrahend.coordinates[i][1];
    }
    return difference;
}

EditedRectangle EditedRectangle::operator / (float factor){  // Overloading operator "/"
    if (factor != 0.0) {  // New code
        EditedRectangle product;
        for (int i = 0; i < 4; i++){  // Loop for each coordinate
            product.coordinates[i][0] = this->coordinates[i][0] / factor;
            product.coordinates[i][1] = this->coordinates[i][1] / factor;
        }
        return product;
    } else {
        throw "Cannot divide by zero";
    }
}



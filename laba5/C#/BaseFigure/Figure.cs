using System;

namespace BaseFigure
{
    public class Figure
    {
        protected int[][] coordinates;  // Array with coordinates of vertices
        
        private bool isParallel(int vertex1, int vertex2, int vertex3, int vertex4, int[][] userCoord)  // Parallelism check
        {
            int[] side1 = {
                userCoord[vertex2][0] - userCoord[vertex1][0],
                userCoord[vertex2][1] - userCoord[vertex1][1]};
            int[] side2 = {
                userCoord[vertex4][0] - userCoord[vertex3][0],
                userCoord[vertex4][1] - userCoord[vertex3][1]};
            
            return side1[0]*side2[1] == side1[1]*side2[0];
        }
        public Figure(int[][] userCoordinates, int amountOfVertices, string typeOfFigure = "")  // Constructor with parameters for 2D figure
        {
            if (amountOfVertices == userCoordinates.Length)  // Figure has specific amount of vertices
            {
                if (userCoordinates[0].Length == 2)  // Figure has 2 coordinates - x and y
                {
                    if (typeOfFigure == "trapezium")
                    {
                        if (isParallel(0, 1, 2, 3, userCoordinates) & isParallel(0, 3, 1, 2, userCoordinates) == false)  // 2 parallel and 2 non-parallel sides
                        {
                            coordinates = userCoordinates;
                        } else {throw new Exception("Wrong vertices order or no parallel sides");}
                    } else {coordinates = userCoordinates;}
                } else {throw new Exception("Wrong amount of coordinates");}
            } else {throw new Exception("Wrong amount of vertices");}
        }

        public double LengthOfSide(int vertex1, int vertex2)  // User picks 2 vertices and if they are right, method returns length of the side
        {
            double length = 0;
            if (vertex1 > 0 & vertex2 > 0 & ((Math.Abs(vertex1 - vertex2) == 1) || (vertex1 == 1 & vertex2 == coordinates.Length) || (vertex2 == 1 & vertex1 == coordinates.Length)))  // Check values of vertices
            {
                length = Math.Sqrt(Math.Pow((coordinates[vertex1-1][0]-coordinates[vertex2-1][0]), 2) + Math.Pow((coordinates[vertex1-1][1]-coordinates[vertex2-1][1]), 2));
            } else {throw new Exception("Wrong vertices order");}
            return Math.Round(length, 3);
        }
    }
}
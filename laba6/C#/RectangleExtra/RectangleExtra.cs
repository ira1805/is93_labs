using System;
namespace RectangleExtra
{
    public class EditedRectangle
    {
        private double[][] coordinates;  // Coordinates of all vertices of the rectangle
        public EditedRectangle()  // Default constructor
        {
            coordinates = new[]
            {
                new[]{0.0, 0.0},
                new[]{0.0, 0.0},
                new[]{0.0, 0.0},
                new[]{0.0, 0.0}
            };
        }
        private bool isPerpendicular(double[] vector1, double[] vector2)  // Perpendicularity check using scalar product
        {
            return (vector1[0]*vector2[0])+(vector1[1]*vector2[1]) == 0;
        }

        public  EditedRectangle(double[][] coordinates)  // Constructor with parameters
        {
            if (coordinates.Length == 4 && coordinates[0].Length == 2)  // New condition
            {
                double[] line1 =
                {
                    coordinates[1][0] - coordinates[0][0],
                    coordinates[1][1] - coordinates[0][1]
                };
                double[] line2 =
                {
                    coordinates[2][0] - coordinates[1][0],
                    coordinates[2][1] - coordinates[1][1]
                };
                double[] line3 =
                {
                    coordinates[3][0] - coordinates[2][0],
                    coordinates[3][1] - coordinates[2][1]
                };
                double[] line4 =
                {
                    coordinates[0][0] - coordinates[3][0],
                    coordinates[0][1] - coordinates[3][1]
                };
                if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
                {
                    this.coordinates = coordinates;
                } else { 
                    //Console.WriteLine("Wrong coordinates, your shape isn't a rectangle");  // Old code
                    throw new Exception("Wrong coordinates, your shape isn't a rectangle"); // New code
                }
            }  else { throw new ArgumentException("Amount of lines and/or coordinates is wrong"); }
        }

        public EditedRectangle(EditedRectangle objectToCopy) // Copy constructor
        {
            if (objectToCopy.coordinates.Length == 4 && objectToCopy.coordinates[0].Length == 2)   // New condition
            {
                double[] line1 =
                {
                    objectToCopy.coordinates[1][0] - objectToCopy.coordinates[0][0],
                    objectToCopy.coordinates[1][1] - objectToCopy.coordinates[0][1]
                };
                double[] line2 =
                {
                    objectToCopy.coordinates[2][0] - objectToCopy.coordinates[1][0],
                    objectToCopy.coordinates[2][1] - objectToCopy.coordinates[1][1]
                };
                double[] line3 =
                {
                    objectToCopy.coordinates[3][0] - objectToCopy.coordinates[2][0],
                    objectToCopy.coordinates[3][1] - objectToCopy.coordinates[2][1]
                };
                double[] line4 =
                {
                    objectToCopy.coordinates[0][0] - objectToCopy.coordinates[3][0],
                    objectToCopy.coordinates[0][1] - objectToCopy.coordinates[3][1]
                };

                if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
                {
                    coordinates = objectToCopy.coordinates;
                }
                else
                {
                    //Console.WriteLine("Wrong coordinates, your shape isn't a rectangle");  // Old code
                    throw new Exception("Wrong coordinates, your shape isn't a rectangle"); // New code
                }
            } else { throw new ArgumentException("Amount of lines and/or coordinates is wrong"); }
        }

        public double Perimeter() // Perimeter of the rectangle
        {
            return Math.Ceiling(2 * ((coordinates[1][0] - coordinates[0][0]) + (coordinates[1][1] - coordinates[2][1])));
        }
        public double Area() // Area of the rectangle
        {
            return Math.Ceiling((coordinates[1][0] - coordinates[0][0]) * (coordinates[1][1] - coordinates[2][1]));
        }

        public double[] CoordTopLeft // Getter of top left vertex of the rectangle
        {
            get { return coordinates[0]; }
        }
        public double[] CoordTopRight // Getter of top right vertex of the rectangle
        {
            get { return coordinates[1]; }
        }
        public double[] CoordBottomRight // Getter of bottom right vertex of the rectangle
        {
            get { return coordinates[2]; }
        }
        public double[] CoordBottomLeft // Getter of bottom left vertex of the rectangles
        {
            get { return coordinates[3]; }
        }

        public string[][] AllCoordinatesString()  // String with all coordinates to get data
        {
            string[][] coordinatesString = new string[4][];
            for (int i = 0; i < 4; i++)
            {
                coordinatesString[i] = new []{
                    coordinates[i][0].ToString(),
                    coordinates[i][1].ToString(),
                };
            }
            return coordinatesString;
        }
            
        public static EditedRectangle operator -(EditedRectangle minuend, EditedRectangle subtrahend)  // Overloading operator "-"
        {
            for (int i = 0; i < 4; i++)  // Loop for each coordinate
            {
                minuend.coordinates[i][0] -= subtrahend.coordinates[i][0];
                minuend.coordinates[i][1] -= subtrahend.coordinates[i][1];
            }
            return minuend;
        }

        public static EditedRectangle operator /(EditedRectangle product, int factor)  // Overloading operator "/"
        {
            foreach (var vertex in product.coordinates)  // Loop for each coordinate
            {
                try  // New code
                {
                    vertex[0] = vertex[0] / factor;
                    vertex[1] = vertex[1] / factor;
                } catch (DivideByZeroException)
                { throw new DivideByZeroException("Can't divide by zero. Factor is equal to zero"); }
            }
            return product;
        }
    }
}
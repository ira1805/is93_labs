using System;

namespace laba4
{
    internal class Program
    {
        class Rectangle
        {
            private double[][] coordinates;  // Coordinates of all vertices of the rectangle
            public Rectangle()  // Default constructor
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
            public Rectangle(double[][] coordinates)  // Constructor with parameters
            {
                double[] line1 = {
                    coordinates[1][0]-coordinates[0][0], 
                    coordinates[1][1]-coordinates[0][1]
                };
                double[] line2 = {
                    coordinates[2][0]-coordinates[1][0], 
                    coordinates[2][1]-coordinates[1][1]
                };
                double[] line3 = {
                    coordinates[3][0]-coordinates[2][0], 
                    coordinates[3][1]-coordinates[2][1]
                };
                double[] line4 = {
                    coordinates[0][0]-coordinates[3][0], 
                    coordinates[0][1]-coordinates[3][1]
                };
                if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
                {
                    this.coordinates = coordinates;
                }
                else
                {
                    Console.WriteLine("Wrong coordinates, your shape isn't a rectangle");
                }

            }

            public Rectangle(Rectangle objectToCopy)  // Copy constructor
            {
                double[] line1 = {
                    objectToCopy.coordinates[1][0]-objectToCopy.coordinates[0][0], 
                    objectToCopy.coordinates[1][1]-objectToCopy.coordinates[0][1]
                };
                double[] line2 = {
                    objectToCopy.coordinates[2][0]-objectToCopy.coordinates[1][0], 
                    objectToCopy.coordinates[2][1]-objectToCopy.coordinates[1][1]
                };
                double[] line3 = {
                    objectToCopy.coordinates[3][0]-objectToCopy.coordinates[2][0], 
                    objectToCopy.coordinates[3][1]-objectToCopy.coordinates[2][1]};
                double[] line4 = {
                    objectToCopy.coordinates[0][0]-objectToCopy.coordinates[3][0], 
                    objectToCopy.coordinates[0][1]-objectToCopy.coordinates[3][1]};
                
                if (isPerpendicular(line1, line2) && isPerpendicular(line2, line3) && isPerpendicular(line3, line4))
                {
                    coordinates = objectToCopy.coordinates;
                }
                else
                {
                    Console.WriteLine("Wrong coordinates, your shape isn't a rectangle");
                }
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
            public double[] CoordBottomLeft // Getter of bottom left vertex of the rectangle
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
            
            public static Rectangle operator -(Rectangle minuend, Rectangle subtrahend)  // Overloading operator "-"
            {
                for (int i = 0; i < 4; i++)  // Loop for each coordinate
                {
                    minuend.coordinates[i][0] -= subtrahend.coordinates[i][0];
                    minuend.coordinates[i][1] -= subtrahend.coordinates[i][1];
                }
                return minuend;
            }

            public static Rectangle operator /(Rectangle product, int factor)  // Overloading operator "/"
            {
                foreach (var vertex in product.coordinates)  // Loop for each coordinate
                {
                    vertex[0] = vertex[0] / factor;
                    vertex[1] = vertex[1] / factor;
                }
                return product;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("IS-93 Kravchenko Olena, 12 variant");
            Rectangle Q1 = new Rectangle();
            
            double[][] userCoordinatesQ2 =  // Coordinates for rectangle Q2
            {
                new[]{-1.0, 1.0},
                new[]{3.0, 1.0},
                new[]{3.0, -2.0}, 
                new[]{-1.0, -2.0}
            };
            Rectangle Q2 = new Rectangle(userCoordinatesQ2);
            Console.WriteLine($"Area of Q2: {Q2.Area()}");
            
            double[][] userCoordinatesQ3 =  // Coordinates for rectangle Q3
            {
                new[]{-4.0, 7.0},
                new[]{5.0, 7.0},
                new[]{5.0, -5.0}, 
                new[]{-4.0, -5.0}
            };
            Rectangle Q3 = new Rectangle(new Rectangle(userCoordinatesQ3));
            
            Console.WriteLine($"Coordinates of top right and bottom left vertices: {Q3.CoordTopRight[0]}, {Q3.CoordTopRight[1]} and {Q3.CoordBottomLeft[0]}, {Q3.CoordBottomLeft[1]}");
            Console.WriteLine($"Perimeter of Q3: {Q3.Perimeter()}");
            
            double[][] userCoordinatesQ4 =  // Coordinates for rectangle Q4
            {
                new[]{-1.0, 4.0},
                new[]{8.0, 1.0},
                new[]{3.0, -6.0},
                new[]{-18.0, -2.0}
            };
            Rectangle Q4 = new Rectangle(userCoordinatesQ4);
            
            Q1 = new Rectangle(Q3 - Q2);  // Q1 = Q3- Q2
            Console.WriteLine("\n\tQ1");
            foreach (var vertex in Q1.AllCoordinatesString())
            {
                Console.WriteLine(string.Join(", ", vertex));
            }
            
            Q1 /= 2;  // Q1 = Q1 / 2
            Console.WriteLine("\tQ1");
            foreach (var vertex in Q1.AllCoordinatesString())
            {
                Console.WriteLine(string.Join(", ", vertex));
            }
        }

    }
}
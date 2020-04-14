using System;
using BaseFigure;

namespace DerivativeTrapezium
{
    public class Trapezium : Figure
    {
        public Trapezium(int[][] userCoordinates) : base(userCoordinates, 4, "trapezium")  // Constructor with parameters for trapezium 
        {}

        public double Perimeter()  // Perimeter of the trapezium
        {
            return LengthOfSide(1, 2) + LengthOfSide(2, 3) + LengthOfSide(3, 4) + LengthOfSide(4, 1);
        }

        public double Area()  // Area of the trapezium
        {
            double top = LengthOfSide(1, 2);
            double bottom = LengthOfSide(3, 4);
            double left = LengthOfSide(4,1);
            double right = LengthOfSide(2,3);
            double temp = (Math.Pow((top-bottom),2) + Math.Pow(left,2) - Math.Pow(right,2))/(2*(top-bottom));  // ((a-b)^2 + c^2 - d^2)/2(a - b);
            double height = Math.Sqrt(Math.Pow(left, 2) - Math.Pow(temp, 2));  // sqrt(c^2 - temp^2)
            return ((top+bottom)*height)/2;  //(a+b)*height/2
        }
        public int[][] GetCoordinates()
        {
            return coordinates;
        }
        public string[][] GetCoordinatesByString()  // String with all coordinates
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
    }
}
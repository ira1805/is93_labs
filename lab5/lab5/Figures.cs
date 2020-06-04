using System;

namespace lab5
{
    class Figures
    {
        public int Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;

        public Figures(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            Ax = x1;
            Ay = y1;
            Bx = x2;
            By = y2;
            Cx = x3;
            Cy = y3;
            Dx = x4;
            Dy = y4;
        }

        public double CalculateSide(int x, int y, int a, int b)
        {
            var side = Math.Sqrt(Math.Pow(a - x, 2) + Math.Pow(b - y, 2));
            return side;
        }
    }
}

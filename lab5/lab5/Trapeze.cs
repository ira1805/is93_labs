using System;

namespace lab5
{
    class Trapeze : Figures
    {
        public Trapeze(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) 
                : base(x1, y1, x2, y2, x3, y3, x4, y4)
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

        public double FindPerimetr()
        {
            var AB = CalculateSide(Ax, Ay, Bx, By);
            var BC = CalculateSide(Bx, By, Cx, Cy);
            var CD = CalculateSide(Cx, Cy, Dx, Dy);
            var AD = CalculateSide(Dx, Dy, Ax, Ay);
            return (AB + BC + CD + AD);
        }

        public double FindSquare()
        {
            var AB = CalculateSide(Ax, Ay, Bx, By);
            var BC = CalculateSide(Bx, By, Cx, Cy);
            var AD = CalculateSide(Dx, Dy, Ax, Ay);
            double h = Math.Sqrt(Math.Pow(AB, 2)-Math.Pow(((AD-BC)/2),2));
            return (AD - BC) / 2 * h;
        }

        public override string ToString()
        {
            return string.Format("A[{0},{1}], B[{2}, {3}], C[{4}, {5}], D[{6}, {7}]",
                this.Ax, this.Ay, this.Bx, this.By, this.Cx, this.Cy, this.Dx, this.Dy);
        }
    }
}

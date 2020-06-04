using System;

namespace lab4
{
    class Rectangle
    {
        public int Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;
        public Rectangle()
        {
            Console.WriteLine("Default constructor");
        }

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            Ax = x1;
            Ay = y1;
            Bx = x2;
            By = y2;
            Cx = x3;
            Cy = y4;
            Dx = x4;
            Dy = y4;
            Console.WriteLine("Сonstructor with parameters");
        }

        public Rectangle(Rectangle Q1)
        {
            Ax = Q1.Ax;
            Ay = Q1.Ay;
            Bx = Q1.Bx;
            By = Q1.By;
            Cx = Q1.Cx;
            Cy = Q1.Cy;
            Dx = Q1.Dx;
            Dy = Q1.Dy;
            Console.WriteLine("Constructor with copy");
        }

        public static Rectangle operator -(Rectangle Q1, Rectangle Q2)
        {
            return new Rectangle(Q1.Ax - Q2.Ax, Q1.Ay - Q2.Ay, Q1.Bx - Q2.Bx, Q1.By - Q2.By, Q1.Cx - Q2.Cx, Q1.Cy - Q2.Cy, Q1.Dx - Q2.Dx, Q1.Dy - Q2.Dy);
        }

        public static Rectangle operator /(Rectangle Q, int x)
        {
            return new Rectangle(Q.Ax / x, Q.Ay / x, Q.Bx / x, Q.By / x, Q.Cx / x, Q.Cy / x, Q.Dx / x, Q.Dy / x);
        }

        public double CalculatePerimetrium()
        {
            var AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
            var BC = Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));
            return ((AB + BC) * 2);
        }

        public double CalculateSquare()
        {
            var AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
            var BC = Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));
            return (AB * BC);
        }

        public override string ToString()
        {
            return string.Format("A[{0},{1}], B[{2}, {3}], C[{4}, {5}], D[{6}, {7}]",
                this.Ax, this.Ay, this.Bx, this.By, this.Cx, this.Cy, this.Dx, this.Dy);
        }
    }
}

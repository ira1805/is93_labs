using System;

namespace LAB6
{
    class Expression
    {
       

        public double A, B, C, D;
        
        public Expression(double a, double b,  double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double Сalculating()
        {
            
            if  ((A / B) <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((C+B-D+A) == 0)
            {
                throw new DivideByZeroException();
            }

            
            return ((4 * Math.Log(10) * (A / B) + 1)/(C+B-D+A));
        }
        
        #region
        public static Expression operator +(Expression example, int num)
        {
            return new Expression(example.A + num, example.B + num, example.C + num, example.D + num);
        }
        public static Expression operator +(Expression example1, Expression example2)
        {
            return new Expression(example1.A + example2.A, example1.B + example2.B, example1.C + example2.C, example1.D + example2.D);
        }
        public static Expression operator -(Expression example, int num)
        {
            return new Expression(example.A - num, example.B - num, example.C - num, example.D - num);
        }
        public static Expression operator -(Expression example1, Expression example2)
        {
            return new Expression(example1.A - example2.A, example1.B - example2.B, example1.C - example2.C, example1.D - example2.D);
        }
        #endregion

    }
}

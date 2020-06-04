using System;

namespace lab6
{
    class Expression
    {
        public int a, b, c, d;
        public Expression(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double Calculation()
        {
            var log = 4 * b - c;
            var den = b + c / d - 1;
            if (den == 0)       //cheking denominator if it = 0
            {
                throw new DividingByNullException();
            }
            if (log <= 0)       //cheking if log expression less than zero
            {
                throw new NegativeExpressionExceptionInLg();
            }
            return (Math.Log(log) * a / den);
        }
        public override string ToString()
        {
            return string.Format("a = {0}, b = {1}, c = {2}, d = {3}", this.a, this.b, this.c, this.d);
        }
    }
}

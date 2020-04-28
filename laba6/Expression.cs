using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionSpace
{
    class Expression
    {
        private double a, c, d, res = 1;

        public Expression()
        {
            d = c = a = 0;
        }

        public Expression(double u_a, double u_c, double u_d)
        {
            try
            {
                if ((u_a < 0) || (u_a == 4))
                    throw new ArgumentException("invalid 'a' value");
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            a = u_a;
            c = u_c;
            d = u_d;
        }

        public void SetVariables(double u_a, double u_c, double u_d)
        {
            if ((u_a < 0) || (u_a == 4))
                throw new ArgumentException("invalid 'a' value");
            a = u_a;
            c = u_c;
            d = u_d;
        }

        public string Calculate()
        {
            if ((a < 0) || (a == 4))
                throw new ArgumentException("invalid 'a' value, result can't be calculated");
            res = (2 * c - d + Math.Sqrt(23 * a)) / (a / 4 - 1);
            return "OK";
        }

        public double Result()
        {
            return res;
        }
    }
}

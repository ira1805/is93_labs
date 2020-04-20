using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    public class ExpressionClass
    {
        private double a, b, c, d;//Our values
        public ExpressionClass(double a,double b,double c,double d)//Constructor with parametrs
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double Value()//Method for output of value our Expression
        {
            if (d > 41)//If d>41 i show massage
            {
                throw new DivideByZeroException("Expression have a zero the root!");//Output message with exception
            }
            else
            {
                if (Math.Sqrt(41 - d) - b * a + c == 0)//If denominator = 0 i show massage with exception
                {
                    throw new DivideByZeroException("Expression have a zero the denominator!");//I show message with exception
                }
                else
                {
                    return(((a * b / 4.0) - 1) / (Math.Sqrt(41 - d) - b * a + c));//Else, i return value of expression
                }
            }
        }
    }
}

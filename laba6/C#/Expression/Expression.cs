using System;

namespace Expression
{
    public class TaskExpression
    {
        private double _variable1, _variable2, _variable3, _variable4;  // a,b,c,d
        public TaskExpression(double a, double b, double c, double d) // Constructor with variables for expression
        {
            _variable1 = a;
            if (d != 0)
            {
                if (4 * b - c > 0)
                {
                    if (b + c / d - 1 != 0)
                    {
                        _variable2 = b;
                        _variable3 = c;
                        _variable4 = d;
                    }
                    else { throw new ArithmeticException($"Wrong value(s) of b/c/d. b + c / d - 1 = {b + c / d - 1}"); }
                }
                else { throw new ArithmeticException($"Wrong value(s) of b and/or c. 4 * b - c = {4 * b - c}"); }
            }
            else { throw new DivideByZeroException("Wrong value of d"); }
        }

        public double GetA() => _variable1;  // Get value of A
        public double GetB() => _variable2;  // Get value of B
        public double GetC() => _variable3;  // Get value of C
        public double GetD() => _variable4;  // Get value of D
        public double GetExpressionValue()  // Calculate expression from the task
        {
            double expressionValue;
            try
            {
                expressionValue = Math.Log10(4 * _variable2 - _variable3) * _variable1/(_variable2 + _variable3 / _variable4 - 1);
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return expressionValue;
        }
    }
}

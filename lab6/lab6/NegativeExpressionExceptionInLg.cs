using System;


namespace lab6
{
    class NegativeExpressionExceptionInLg : Exception
    {
        public NegativeExpressionExceptionInLg() : base("Expression in lg can not be negative"){}
    }
}

using System;

namespace lab6
{
    class DividingByNullException : Exception
    {
        public DividingByNullException() : base("Expression can not be divided by null"){}
    }
}

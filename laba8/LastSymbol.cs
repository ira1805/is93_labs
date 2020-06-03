using System;

namespace LastSymNamespace
{
    class LastSymbol
    {

        static public int Static(string str)   //статична версія методу
        {
            return str.Length;
        }

        public int Example(string str)   //екземплярна версія методу
        {
            return str.Length;
        }
    }
}
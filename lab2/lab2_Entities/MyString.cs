using System;
using System.Linq;

namespace lab2_Entities
{
    public class MyString
    {
        private readonly char[] ConsonantLetters = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'x', 'z' };
        private char[] _value;

        public MyString(char[] str)
        {
            _value = str;
        }


        public int GetLength()
        {
            return _value.Length;
        }


        public int GetCountOfConsonantLetters()
        {
            int count = 0;
            foreach (var c in _value)
            {
                if (ConsonantLetters.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
        public void DeleteWhiteSpaces()
        {
            if (_value[_value.Length - 1] == ' ')
            {
                Array.Resize(ref _value, _value.Length - 1);
            }
            char temp;
            if (_value[0] == ' ')
            {
                foreach (var i in _value)
                {
                    temp = _value[i];
                    _value[i] = _value[i + 1];
                    _value[i + 1] = temp;
                }
                Array.Resize(ref _value, _value.Length - 1);
            }

        }

        public void Print()
        {
            foreach (var c in _value)
            {
                Console.Write(c);
            }
        }
    }
}

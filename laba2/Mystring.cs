using System;
using System.Collections.Generic;
using System.Text;

namespace Mulik_laba2
{
    public class Mystring
    {
        private char[] str;
        private int len;
        public Mystring(string input = "")
        {
            str = input.ToCharArray();
            len = input.Length;
        }
        public override string ToString()
        {
            return new string(str);
        }
        public int Mylenght()
        {
            return len;
        }
        public Mystring input()
        {
            string input;
            input = Console.ReadLine();
            Mystring newstr = new Mystring();
            newstr.str = input.ToCharArray();
            newstr.len = input.Length;
            return newstr;
        }


        public Mystring replace(char was, char will)
        {
            Mystring newStr = new Mystring();
            for (int i = 0; i < str.Length; i++)
            {
                if (was == str[i])
                {
                    str[i] = will;
                }
            }
            return newStr;
        }
    }
}

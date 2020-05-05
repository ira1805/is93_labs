using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_cheak
{
    public delegate bool DelegeteClass(string s);//Make class of delegate!)
    class Cheak
    {
        public static bool FindL(string s)//Static method for find litteral!!!
        {
            bool flag = false;
            foreach (var c in s)
            {
                if (Char.IsLetter(c))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool FindL2(string s)//Examples method for find litteral!!!
        {
            bool flag = false;
            foreach (var c in s)
            {
                if (Char.IsLetter(c))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

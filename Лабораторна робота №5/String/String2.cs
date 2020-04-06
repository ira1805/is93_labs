using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Str//Basic class
    {
        virtual public int length(char[] s){ return 0; }//Virtual method for calculation the lenght of our string
        virtual public char[] Change(){ return null; }//Virtual method for echange symbol to some symbols
    }
    public class Symbols : Str//Class from String
    {
        private char []s;//Init arrgs
        public Symbols(char[] s)//Make designer with parametrs
        {
            this.s = s;
        }
        public override int length(char[] s)//Override method from class of String for calculation length of our string!!!
        {
            return s.Length;
        }
        public override char[] Change()//Override method from class of String for exchenge one symbol to some symbols
        {
            char[] s3 = new char[s.Length * 2];
            for(int i=0;i<length(s);i++)
            {
                s3[i] = s[i];
            }
            for (int i = 0; i < length(s3); i++)
            {
                if(s3[i]=='#')
                {
                    char[] s2=new char[length(s3)];
                    for(int p=0;p<length(s3);p++)
                    {
                        s2[p] = s3[p];
                    }
                    s3[i] = '!';
                    s3[i + 1] = '!';
                    for(int j=i+2;j<length(s)+2;j++)
                    {
                        s3[j] = s2[j - 1];
                    }
                }
            }
            int k = 0;
            for(int i=0;i<length(s3);i++)
            {
                if(s3[i]=='\0')
                {
                    k = i;
                    break;
                }
            }
            this.s = new char[k];
            for (int i = 0; i < k; i++)
            {
                s[i] = s3[i];
            }
            return s;
        }
    }
    public class Noumbers:Str
    {
        private char[] s;//Init arrgs
        public Noumbers(char[] s)//Make designer with parametrs
        {
            this.s = s;
        }
        public override int length(char[] s)//Override method from class of String for calculation length of our string!!!
        {
            return s.Length;
        }
        public override char[] Change()//Override method from class of String for exchenge one symbol to some symbols
        {
            char[] s3 = new char[s.Length * 2];
            for (int i = 0; i < length(s); i++)
            {
                s3[i] = s[i];
            }
            for (int i = 0; i < length(s3); i++)
            {
                if (s3[i] == '3')
                {
                    char[] s2 = new char[length(s3)];
                    for (int p = 0; p < length(s3); p++)
                    {
                        s2[p] = s3[p];
                    }
                    s3[i] = '1';
                    s3[i + 1] = '1';
                    for (int j = i + 2; j < length(s) + 2; j++)
                    {
                        s3[j] = s2[j - 1];
                    }
                }
            }
            int k = 0;
            for (int i = 0; i < length(s3); i++)
            {
                if (s3[i] == '\0')
                {
                    k = i;
                    break;
                }
            }
            this.s = new char[k];
            for (int i = 0; i < k; i++)
            {
                s[i] = s3[i];
            }
            return s;
        }
    }
}

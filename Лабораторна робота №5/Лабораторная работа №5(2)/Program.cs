using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strings;

namespace Лабораторная_работа__5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Samilenko Oleksandr IS-93");
            char[] s;
            Console.WriteLine("Input string:");
            string s2=(Console.ReadLine());
            s = new char[s2.Length];
            for(int i=0;i<s2.Length;i++)
            {
                s[i] = s2[i];
            }
            Str obj1 = new Symbols(s);
            s = obj1.Change();
            Console.WriteLine(s);
            obj1 = new Noumbers(s);
            s = obj1.Change();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

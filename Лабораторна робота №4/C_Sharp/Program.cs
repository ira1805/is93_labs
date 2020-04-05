using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_forMainProgram;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Samilenko Oleksandr IS-93 ");
            Console.Write("Input the string: ");
            s = Console.ReadLine();
            Class1 R1 = new Class1();
            Class1 R2 = new Class1(s);
            Class1 R3 = new Class1(R2);
            R2 = R2 / 2;
            Console.WriteLine(R2.GetStr());
            R1 = R2 + R3;
            Console.WriteLine(R1.GetStr());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Laba_4;
   class Program
    {
   static void Main(string[] args)
    {
      string str;
         Console.Write("Input row: ");
      str = Console.ReadLine();
         Rows CB1 = new Rows();
         Rows CB3 = new Rows(str);
         Rows CB2 = new Rows(CB3);
            CB3 = CB3 * 2;
         Console.WriteLine("After multiplication:");
         Console.WriteLine(CB3.Return_Str());
            CB1 = CB2 + CB3;
         Console.WriteLine("After sum:");
         Console.WriteLine(CB1.Return_Str());
         Console.ReadKey();
    }
}

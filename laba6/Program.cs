using System;
using ExpressionSpace;

namespace laba6_oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
			Expression[] arr = new Expression[3];
			arr[0] = new Expression();
			Console.WriteLine("Baranov Dmytro IS-93\n\n\nfirst expression\n  a = 0\n  c = 0\n  b = 0\n  calculate:  " 
				+ arr[0].Calculate() + "\n  result:  " + arr[0].Result() + "\n");
			arr[1] = new Expression(2, 10, 6);
			Console.WriteLine("second expression\n  a = 2\n  c = 10\n  b = 6\n  calculate:  "
				+ arr[1].Calculate() + "\n  result:  " + arr[1].Result() + "\n");
			arr[2] = new Expression(4, 6, 7);
			Console.WriteLine("Baranov Dmytro IS-93\n\n\nfirst expression\n  a = 4\n  c = 6\n  b = 7\n  calculate:  "
				+ arr[2].Calculate() + "\n  result:  " + arr[2].Result() + "\n");
			Console.ReadKey();
		}
    }
}

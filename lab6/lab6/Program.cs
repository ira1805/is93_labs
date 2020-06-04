using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] {1, 6, 5};
            int[] b = new int[3] {-2, 0, 3};
            int[] c = new int[3] {4, 1, 3};
            int[] d = new int[3] {9, 1, 3};

            for(int i = 0; i < 3; i++)
            {
                var expression = new Expression(a[i], b[i], c[i], d[i]);
                Console.WriteLine($"Coeficients are: {expression}");
                try
                {
                    var result = expression.Calculation();
                    Console.WriteLine($"Result = {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}

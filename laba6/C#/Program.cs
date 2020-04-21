using System;
using Expression;
namespace laba6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IS-93 Kravchenko Olena, 12 variant");
            TaskExpression[] objectArray =
            {
                new TaskExpression(1, 26, 4, 2),  // No errors
                // Uncomment to catch exceptions
                //new TaskExpression(8, 1, 5, 10),  //  4*b-c < 0
                //new TaskExpression(5, 4, 2, 0),  // d = 0
                //new TaskExpression(3, 5, 10, -2.5),  // b+c/d-1 = 0
            };
            foreach (var objectExample in objectArray)
            {
                Console.WriteLine(objectExample.GetExpressionValue());
            }
        }
    }
}
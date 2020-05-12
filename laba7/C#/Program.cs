using Task3;
using System;

namespace Laba7
{
    internal class Program
    {
        public delegate int DelegateTask2(char uSymbol, string uString);
        private static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        
        public static void Main(string[] args)
        {
            // Task 2
            string test1 = "Hello world!";  // 3 - 'l'
            string test2 = "Flood door room master";  // 6 - 'o'
            string test3 = "3,141592653589793238462643383279";  // 7- '3'
            string test4 = "step on no pets";  // 2 - 't'
            SymbolCounter taskCounter = new SymbolCounter();
            DelegateTask2 delegateTest = SymbolCounter.StaticCountSymbol;
            delegateTest += taskCounter.CountSymbol;
            Console.WriteLine("Task 2 results: ");
            Console.WriteLine(delegateTest('l', test1));
            Console.WriteLine(delegateTest('o', test2));
            Console.WriteLine(delegateTest('3', test3));
            Console.WriteLine(delegateTest('t', test4));
            
            // Task 4
            Pool userPool = new Pool(new [] {2.0,8.0,4.0});  // Volume = 64
            userPool.RegisterHandler(PrintMessage);
            userPool.AddWater(40);
            userPool.DrainWater(-20);
            userPool.DrainWater(10);
            userPool.AddWater(64);  // Overflow
        }

    }
}
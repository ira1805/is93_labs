using System;

namespace laba8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            LongList test1 = new LongList();
            LongList test2 = new LongList();
            LongList test3 = new LongList();
            for (int i = 0; i < 5; i++)  // Add 5 random numbers to structures
            {
                test1.Add(rand.Next(10, 100));
                test3.Add(rand.Next(10, 100)); 
            }
            test3.Add(5);
            test2.Add(3);  // Position = 1
            test2.Add(45);  // Position = 2
            test2.Add(30);  // Position = 3
            test2.Add(96);  // Position = 4
            test2.Add(6);  // Position = 5
            test2.Add(5);  // Position = 6
            test2.Add(15);  // Position = 7
            test2.Add(25);  // Position = 8
            
            Console.WriteLine($"Position of 5: {test3.GetPosition(5)}");
            test1.DeleteGreaterAvg();
            Console.WriteLine("Amount of elements multiples of 5 that located in even positions: " +
                              $"{test2.FindSpecialElements()}");
            test3.Delete(5);
            try
            {
                Console.WriteLine($"Position of 5: {test3.GetPosition(5)}");
                
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
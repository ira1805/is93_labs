using System;

namespace lab8
{
    class Program
    {
        static private void Handler()
        {
            Console.WriteLine("Pool is overflowing");
        }
        static void Main(string[] args)
        {
            var Pool1 = new Pool(2, 50, 50);
            int maxVolume = Pool1.CalculateVolume();
        
            Pool1.Overflowing += new OverflowDelegat (Handler);

            Pool1.AddingWater(550, maxVolume);
        }
    }
}

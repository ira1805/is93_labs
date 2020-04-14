using System;
using BaseString;
using DerivativeNumerals;
using DerivativeSymbols;
using DerivativeTrapezium;

namespace laba5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IS-93 Kravchenko Olena, 12 variant");
            // 1 task
            int[][] userCoordinates1 =
            {
                new[] {-3, 4},
                new[] {2, 4},
                new[] {4, -1},
                new[] {-5, -1}};
            int[][] userCoordinates2 =
            {
                new[] {4, 2},
                new[] {6, 1},
                new[] {6, -4},
                new[] {-4, -4}};  // Wrong coordinates test(no parallel sides)
            int[][] userCoordinates3 =
            {
                new[] {2, 2},
                new[] {2, -3},
                new[] {-3, -3},
                new[] {-3, 3}};
            Trapezium userTrapezium1 = new Trapezium(userCoordinates1);
            Trapezium userTrapezium3 = new Trapezium(userCoordinates3);
            
            Console.WriteLine($"Area of the first trapezium: {Math.Round(userTrapezium1.Area(), 3)}");
            Console.WriteLine($"Perimeter of the third trapezium: {userTrapezium3.Perimeter()}");
            Console.WriteLine("\tTrapezium 3");
            foreach (var vertex in userTrapezium3.GetCoordinatesByString())
            {
                Console.WriteLine(string.Join(", ", vertex));
            }
            // Uncomment to get exceptions
            //Trapezium userTrapezium2 = new Trapezium(userCoordinates2);  // Wrong vertices order test
            //Console.WriteLine(userTrapezium1.LengthOfSide(1,3));  // Wrong vertices order test
            
            // 2 task
            ModString userString1 = new Numeral("hello World!");
            ModString userString2 = new Symbols("knock-knock-knock");
            Numeral userNumeral = (Numeral) userString1;
            Symbols userSymbol = (Symbols) userString2;
            userNumeral.Increase();
            Console.WriteLine("Increasing userNumeral variable...\n{0}",userNumeral.GetString());
            Console.WriteLine("Increasing userSymbol variable...\n{0}",userSymbol.GetString());
            userSymbol.Increase();
            Console.WriteLine("Increasing userSymbol variable...\n{0}",userSymbol.GetString());
        }
    }
}
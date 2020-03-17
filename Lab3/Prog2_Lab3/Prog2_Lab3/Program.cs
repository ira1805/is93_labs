using System;
using Prog2_Lab3_Lib;

namespace Prog2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            SymbolMatrix sym = new SymbolMatrix(new string[2] { "Hello world", "This is a 2d array" }); // Демонстрація конструктора
            WriteOut(sym);
            Console.WriteLine();

            Console.Write("Другий символ кожного рядка: ");
            Console.WriteLine(sym[1]); // Демонстрація get індексатора
            sym[1] = new char[2] { 'i', 'i' }; // Демонстрація set індексатора
            Console.Write("Другий символ кожного рядка пiсля змiни: "); 
            Console.WriteLine(sym[1]);
            Console.Write("Двадцятий символ кожного рядка: ");
            Console.WriteLine(sym[19]); // Демонстрація get індексатора для значень індекса більших розміра рядка
            Console.WriteLine();

            WriteOut(sym);
            Console.WriteLine();

            Console.WriteLine("Кiлькiсть цифр в усiх рядках: " + sym.NumofNums); // Демонстрація властивості читання кількості цифр
        }

        // Метод для виведення масиву на екран. Поза класу бо використовує консоль.
        static void WriteOut(SymbolMatrix input)
        {
            for (int i = 0; i < input.GetWhole().Length; i++)
            {
                Console.WriteLine(input.GetWhole()[i]);
            }
            return;
        }
    }
}

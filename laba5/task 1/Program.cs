using System;
using classes;

namespace laba5csinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SymbolStrings str = new SymbolStrings("slzyxfjafgsjer;07954-_@%$&()!7912345&");
            Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");
            Console.WriteLine(str.GetStr());
            Console.WriteLine("відсортований за спаданням рядок: " + str.Sort());
            Console.WriteLine("кількість символів = " + str.Length());
            Console.ReadKey();
        }
    }
}

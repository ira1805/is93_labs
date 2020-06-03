using System;
using System.Collections.Generic;

namespace laba3
{
    public class MyText
    {
        private List<string> text;       // створення змінної, що зберігає текст
        private int vowles = 0;          // ініціалізація змінної, що відповідає за кількість голосних літер
        readonly char[] vow = { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'і', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я', 'І', 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'};  // голосні літери
        public MyText()                // конструктор
        {
            text = new List<string>();
        }

        public void Add(string input)  // метод додавання нової строки
        {
            text.Add(input);              // додавання строки в текст
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vow.Length; j++)
                {
                    if (vow[j] == input[i]) { vowles++; }  // інкрементація змінної, в якій зберігається кількість голосних літер
                }
            }
        }

        public int Vowles             // властивість виведення кількості голосних літер
        {
            get
            {
                return vowles;      // виведення змінної, що відповідає за кількість голосних літер
            }
        }

        public int this[int index]  // індексатор
        {
            get
            {
                if (index >= 0 && index < text.Count)
                {
                    int symbols = text[index].Length;
                    return symbols;
                }
                else
                {
                    return 0;
                }
                    
            }
        }

        public override string ToString()               // метод для виведення тексту
        {
            string output = "";
            foreach (var x in text)                   // цикл виведення тексту
                output += x;
            return output;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;    // підключення символів кирилиці
            MyText text = new MyText();                // створення об'єкту класу, що інкапсулює текст         
            text.Add("Цей текст є об'єктом класу MyText.\n");            // заповнення об'єкту класу текстом
            text.Add("У класі MyText є змінна, яка містить у собі\n");
            text.Add("кількість голосних літер цього тексту, якщо\n");
            text.Add("мова тексту українська, русский або english.\n");
            text.Add("Введіть номер рядку щоб дізнатись кількість символів у ньому: ");
            Console.WriteLine("Мулік Рустам ІС-93\n____________________________\n\nтекст:\n");
            Console.WriteLine(text);
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(text[index - 1]);
            Console.WriteLine("Кількість голосних літер: ");
            Console.WriteLine(text.Vowles);
            Console.ReadKey();
        }
    }
}

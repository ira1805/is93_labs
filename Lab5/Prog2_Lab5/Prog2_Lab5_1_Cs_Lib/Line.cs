using System;
using System.Collections.Generic;
using System.Text;

namespace Prog2_Lab5_1_Cs_Lib
{
    public class Line
    {
        // Закритий двовимірний масив елементів символьного типу
        protected char[] symbols;

        // Конструктор класа
        public Line(string input)
        {
            symbols = new char[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                symbols[j] = input[j];
            }
        }

        // Повертає весь массив, для простоти виводу
        public virtual char[] GetWhole()
        {
            return symbols;
        }

        // Віртуальна функція для визначення довжини рядка
        public virtual int Length()
        {
            return symbols.Length;
        }

        // Віртуальна функція для підрахунку кількості введеного символу
        public virtual int Count(char target)
        {
            int count = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == target) {
                    count++;
                }
            }
            return count;
        }

        // Віртуальна функція підрахунку буз аргументів
        // Так як похідні класи не використовують аргументи, то попередній метод перевантажуються
        public virtual int Count()
        {
            return this.Length();
        }
    }

    public class Symbols : Line
    {
        // Конструктори класу не наслідуються, але базовий конструктор викликається похідним класом
        public Symbols(string input) : base(input)
        {
        }

        // Перезапис віртуальної функції підрахунку, рахує кількість символів '*'
        public override int Count()
        {
            int count = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == '*')
                {
                    count++;
                }
            }
            return count;
        }

        // Базова функція Length задовільняє потреби підкласу і не переписується
    }
    public class LargeLetters : Line
    {
        // Конструктори класу не наслідуються, але базовий конструктор викликається похідним класом
        public LargeLetters(string input) : base(input)
        {
        }

        // Перезапис віртуальної функції підрахунку, рахує кількість символів 'В'
        public override int Count()
        {
            int count = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == 'В')
                {
                    count++;
                }
            }
            return count;
        }

        // Базова функція Length задовільняє потреби підкласу і не переписується
    }
}

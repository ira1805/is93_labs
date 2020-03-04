using System;

namespace LAB_2
{
    class Text
    {
        public OsnHelp[] text;
        public int n;

        public Text(int n, OsnHelp[] text)
        {
            this.n = n;
            this.text = text;
        }
        //Вивід тексту
        public void outputText()
        {
            for (int i = 0; i < n; i++)
            {
                text[i].outputString();
                Console.WriteLine();
            }
        }
        //Добавляння рядка
        public void addLine(OsnHelp line)
        {
            text[n++] = line;
        }
        //Заміна рядка
        public void removeLine(int pos)
        {
            for (int i = pos - 1; i < n; i++)
            {
                text[i] = text[i + 1];
            }
            n--;
        }
        //К-сть рядків
        public int NumberOfRows()
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
                counter++;
            return counter;
        }
        public OsnHelp Numerrow()
        {
            int times = 0;
            for (int i = 0; i < n; i++)
            {
                if (text[i] != text[i + 1])
                    times *= 1; ;
            }
            return text[times];

        }
        //Найбільший рядок
        public OsnHelp findBiggest()
        {
            int max = 0;
            int maxLen = text[0].getLength();
            for (int i = 0; i < n; i++)
            {
                if (maxLen < text[i].getLength())
                {
                    maxLen = text[i].getLength();
                    max = i;
                }
            }

            return text[max];
        }
        //Довжина тексту
        public int getLength()
        {
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += text[i].getLength();
            }

            return total;
        }
        //Очистка
        public void clearText()
        {
            for (int i = 0; i < n; i++)
            {
                text[i] = new OsnHelp();
            }
            n = 0;
        }
        //Рядок з цифр
       
    }
}
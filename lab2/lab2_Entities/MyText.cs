using System;
using System.Linq;

namespace lab2_Entities
{
    public class MyText
    {
        private MyString[] _stringsArray;

        public MyText(MyString[] stringsArray)
        {
            _stringsArray = stringsArray;
        }
        // 1 method
        public void AddingString(MyString str)
        {
            _stringsArray = _stringsArray.Append(str).ToArray();
        }
        // 2 method
        public void DeleteString(int index)
        {
            var NewText = new MyString[_stringsArray.Length - 1];
            for (int i = 0; i < index - 1; i++)
            {
                NewText[i] = _stringsArray[i];
            }
            for (int i = index; i < _stringsArray.Length; i++)
            {
                NewText[i - 1] = _stringsArray[i];
            }
            _stringsArray = NewText;
        }
        // 3 method
        public void CleaneArrray()
        {
            var EmptyText = new MyString[_stringsArray.Length - 1];
            _stringsArray = EmptyText;
        }
        // 4 method
        public int GetShortestStringLength()
        {
            int minLegth = int.MaxValue;

            foreach (var str in _stringsArray)
            {
                var legth = str.GetLength();
                if (legth < minLegth)
                {
                    minLegth = legth;
                }
            }
            return minLegth;
        }
        // 5 method
        public double GetConsonantLettersPercentage()
        {
            int sumStringsLegth = 0;
            int sumConsonantLetters = 0;

            foreach (var str in _stringsArray)
            {
                sumStringsLegth += str.GetLength();
                sumConsonantLetters += str.GetCountOfConsonantLetters();
            }

            return ((double)sumConsonantLetters / sumStringsLegth) * 100;
        }
        // 6 method
        public void DeleteWhiteSpaces()
        {
            foreach (var str in _stringsArray)
            {
                str.DeleteWhiteSpaces();
            }
        }

        public void Print()
        {
            foreach (var str in _stringsArray)
            {
                str.Print();
            }
            Console.WriteLine();
        }
    }
}

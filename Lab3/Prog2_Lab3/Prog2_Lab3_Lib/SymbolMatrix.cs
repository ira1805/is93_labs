using System;

namespace Prog2_Lab3_Lib
{
    public class SymbolMatrix
    {
        // Закритий двовимірний масив елементів символьного типу
        private char[][] mat;
        // Закритий елемент, що містить кількість цифр у масиві 
        private int numofNums;

        // Конструктор класа
        public SymbolMatrix(string[] input)
        {
            mat = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                mat[i] = new char[input[i].Length];
                for (int j = 0; j < input[i].Length; j++)
                {
                    mat[i][j] = input[i][j];
                }
            }

        }

        // Одновимірний індексатор
        // get повертає рядок зі значеннями заданого стовпця масиву 
        // set записує значення з введеного рядка в стовпець масиву 
        public char[] this[int index]
        {
            get
            {
                char[] column = new char[this.mat.Length];
                for (int i = 0; i < this.mat.Length; i++)
                {
                    if (index < this.mat[i].Length)
                    {
                        column[i] = this.mat[i][index];
                    }
                    // Якщо рядок коротший індекса, додає нульовий символ
                    else
                    {
                        column[i] = '\0';
                    }
                }
                return column;
            }
            set
            {
                for (int i = 0; i < mat.Length; i++)
                {
                    mat[i][index] = value[i];
                }
            }
        }

        // Властивість для читання кількості цифр у масиві
        // Так як кількість цифр у масиві залежить від масиву, розраховує кількість, зберігає її в елементі numofNums, котрий повертає
        public int NumofNums
        {
            get
            {
                numofNums = 0;
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        if (Char.IsDigit(mat[i][j]))
                        {
                            numofNums++;
                        }
                    }
                }
                return numofNums;
            }
        }

        // Повертає весь массив, для простоти виводу
        public char[][] GetWhole()
        {
            return mat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private int d=1;//Переменная умножения
        public int[,] arr;//Иннициализация масива внутри класа
        public int n; //Значение количества строк
        public int m; //Значение количества столбцов
        public Class1(int n1, int m1, int[,] b)//Конструкто для получения масива в клас
        {
            n = n1;
            m = m1;
            arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = b[i, j];
                }
            }
            d = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d *= arr[i, j];
                }
            }
        }
        public int Dobutok//Описание свойства умножения
        {
            get
            {
                return d;
            }
        }
        public void GetMatrix(int n1, int m1, int [,]b)//Получение масива в клас
        {
            n = n1;
            m = m1;
            arr = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    arr[i,j] = b[i,j];
                }
            }
            d = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d *= arr[i, j];
                }
            }
        }
        public double this[int index]//Индексатор, для нахождения среднего арифметического элементов заданой строки
        {
            get
            {
                if (index > n - 1)
                {
                    Console.WriteLine("You outputed index out of range!");
                    return 0;
                }
                else
                {
                    double s = 0;
                    for (int j = 0; j < m; j++)
                    {
                        s += arr[index, j];
                    }
                    s /= n;
                    return s;
                }
            }
        }
    }
}

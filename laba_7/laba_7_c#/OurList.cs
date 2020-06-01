using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Progect
{
    internal class Node// Класс узла
    {
        public char Value { get; set; }
        public Node Next { get; set; }
    }
    internal class OurList // Мой класс списка
    {
        private int Size { get; set; }//размер
        private Node Head { get; set; }//Руководитель ссылки
        private Node Element { get; set; }//Последняя ссылка
        public void Push(char value)//Метод для добавления нового элемента в последнем
        {
            Node NodeOfNew = new Node() { Value = value };
            if (Head == null)
            {
                Head = NodeOfNew;
                Console.WriteLine(Head.Value);
            }
            else
            {
                Element.Next = NodeOfNew;
                Console.WriteLine(NodeOfNew.Value);
            }
            Element = NodeOfNew;
            Size++;
        }
        public void OutPutList()                          //Способ вывода нашего списка
        {
            Node tpr = Head;
            while (tpr != null)
            {
                Console.Write(tpr.Value.ToString() + " ");
                tpr = tpr.Next;
            }
            Console.WriteLine();
        }
        public int CountOfElem()                                    //Метод, который выводит количество всех елементов 
        { 
            int k = 0;
            Node ptr = Head;
            while (ptr != null)
            {
                if (ptr.Value % 4 == 0)
                {
                    k += 1;
                }
                ptr = ptr.Next;
            }
            return k;
        }
        public void Out_Put_Number() 
        {
            Node ptr = Head;
            int k = 0;
            while (ptr != null)
            {
                if (k % 2 == 0)
                {
                    ptr.Value = 0;
                }
                ptr = ptr.Next;
                k++;
            }
        }
    }
}
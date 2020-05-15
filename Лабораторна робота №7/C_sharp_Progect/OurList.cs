using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Progect
{
    internal class Node//Class node
    {
        public short Value { get; set; }
        public Node Next { get; set; }
    }
    internal class OurList//My class of list
    {
        private int Size { get; set; }//Size
        private Node Head { get; set; }//Head referense
        private Node Element { get; set; }//Last referense
        public void Push(short value)//Method for push new element in the last
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
        public void OutPutList()//Method for output our list
        {
            Node tpr = Head;
                while (tpr!= null)
                {
                    Console.Write(tpr.Value.ToString() + " ");
                    tpr = tpr.Next;
                }
                Console.WriteLine();
        }
        public int CountOfElem()//Method for count of elements, with multiples of four
        {
            int k = 0;
            Node ptr = Head;
            while(ptr!=null)
            {
                if(ptr.Value%4==0)
                {
                    k += 1;
                }
                ptr = ptr.Next;
            }
            return k;
        }
        public void ExchangeForZero()//Method for exchange element, with has a position of multiples of two,on 0;
        {
            Node ptr = Head;
            int k = 0;
            while(ptr!=null)
            {
                if(k%2==0)
                {
                    ptr.Value = 0;
                }
                ptr = ptr.Next;
                k++;
            }
        }
    }
}

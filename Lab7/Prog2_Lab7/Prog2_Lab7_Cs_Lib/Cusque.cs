using System;

namespace Prog2_Lab7_Cs_Lib
{
    public class Node
    {
        public double val;
        public Node next;
        public Node prev;

        public Node(double inVal, Node inNext = null, Node inPrev = null)
        {
            val = inVal;
            next = inNext;
            prev = inPrev;
        }
        // Вставка в початок списку
        public Node NewPrev(double value)
        {
            prev = new Node(value, this);
            return prev;
        }
        // Пошук максисума
        public Node FindMax(Node max)
        {
            if (val > max.val) { max = this;  }
            if (next == null) { return max; }
            else { return next.FindMax(max); }
        }
        // Видалення елементу зі списку
        public void Eliminate()
        {
            if (next != null) { next.prev = prev; }
            if (prev != null) { prev.next = next; }
        }
    }

    public class Cusque
    {
        // Голова не має попереднього елементу
        private Node head;
        // Хвост не має наступного елементу
        private Node tail;

        // Вставка в початок списку
        public void NewHead(double val)
        {
            Node newNode = head.NewPrev(val);
            head = newNode;
        }
        public Cusque(double val)
        {
            Node n = new Node(val);
            head = n;
            tail = n;
        }
        // Видалення елементiв після максимального
        public void ElimAfterMax()
        {
            Node Max = head.FindMax(head);
            Max.next = null;
            tail = Max;
        }
        // Пошук середнього значення
        private double FindAverage()
        {
            double avg = 0;
            int count = 0;
            Node cur = head;
            while (cur != null)
            {
                avg += cur.val;
                cur = cur.next;
                count += 1;
            }
            avg = avg / count;
            return avg;
        }
        // Видалення елементів менше середнього
        public void ElimBelowAverage()
        {
            double average = FindAverage();
            Node cur = head;
            while (cur != null)
            {
                if (cur.val < average)
                {
                    cur.Eliminate();
                    if (tail == cur) { tail = cur.prev; }
                    if (head == cur) { head = cur.next; }
                }
                cur = cur.next;
            }
        }
        // Запис значень списку в масив
        public double[] MakeValueArray()
        {
            int count = 0;
            Node cur = head;
            while (cur != null)
            {
                cur = cur.next;
                count += 1;
            }
            cur = head;
            double[] valarray = new double[count];
            for (int i = 0; i < count; i++)
            {
                valarray[i] = cur.val;
                cur = cur.next;
            }
            return valarray;
        }
        public Node Head() { return head; }
        public Node Tail() { return tail; }
    }
}

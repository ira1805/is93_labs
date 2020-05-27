using System;

namespace Prog_Lib
{
    public class Vuzol
    {
        public double val;
        public Vuzol next;
        public Vuzol prev;

        public Vuzol(double inVal, Vuzol inNext = null, Vuzol inPrev = null)
        {
            val = inVal;
            next = inNext;
            prev = inPrev;
        }
        public Vuzol NewPrev(double value)
        {
            prev = new Vuzol(value, this);
            return prev;
        }
        public Vuzol FindMax(Vuzol max)
        {
            if (val > max.val) { max = this;  }
            if (next == null) { return max; }
            else { return next.FindMax(max); }
        }
        public void Delete()
        {
            if (next != null) { next.prev = prev; }
            if (prev != null) { prev.next = next; }
        }
    }

    public class lib
    {
        private Vuzol head;
        private Vuzol tail;

        public void NewHead(double val)
        {
            Vuzol newVuzol = head.NewPrev(val);
            head = newVuzol;
        }
        public lib(double val)
        {
            Vuzol n = new Vuzol(val);
            head = n;
            tail = n;
        }
        public void DelAfterMax()
        {
            Vuzol Max = head.FindMax(head);
            Max.next = null;
            tail = Max;
        }
        private double FindAverage()
        {
            double average = 0;
            int count = 0;
            Vuzol current = head;
            while (current != null)
            {
                average += current.val;
                current = current.next;
                count += 1;
            }
            average = average / count;
            return average;
        }
        public void DelBelowAverage()
        {
            double average = FindAverage();
            Vuzol current = head;
            while (current != null)
            {
                if (current.val < average)
                {
                    current.Delete();
                    if (tail == current) { tail = current.prev; }
                    if (head == current) { head = current.next; }
                }
                current = current.next;
            }
        } 
        public double[] FillArray()
        {
            int count = 0;
            Vuzol current = head;
            while (current != null)
            {
                current = current.next;
                count += 1;
            }
            current = head;
            double[] valarray = new double[count];
            for (int i = 0; i < count; i++)
            {
                valarray[i] = current.val;
                current = current.next;
            }
            return valarray;
        }
        public Vuzol Head() { return head; }
        public Vuzol Tail() { return tail; }
    }
}

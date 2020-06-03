using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace laba7cs
{
    class LinkedList
    {
        private LinkedListNode head;
        private LinkedListNode tail;

        public LinkedList()
        {

        }

        public void AddAfter(LinkedListNode node, short value)
        {
            LinkedListNode newNode = new LinkedListNode(value, node.next);
            node.next = newNode;
        }

        public void InitList(short[] arr)  
        {
            for (int i = 0; i < arr.Length; i++)
            {
                AddEnd(arr[i]);
            }
        }

        public void AddEnd(short value)
        {
            if(head == null)
            {
                head = tail = new LinkedListNode(value);
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.next;
            }
        }

        public int Divaded(short div)
        {
            LinkedListNode ptr = head;
            int count = 0;
            while (ptr.next != null)
            {
                if(ptr.value % 7 == 0)
                {
                    count++;
                }
                ptr = ptr.next;
            }
            return count;
        }

        public void MoreThanMiddle()
        {
            LinkedListNode ptr = head;
            short sum = 0;
            short count = 0;
            while (ptr.next != null)
            {
                sum += ptr.value;
                count++;
                ptr = ptr.next;
            }
            ptr = head;
            while(ptr.next != null)
            {
                if (ptr.value > (sum/count))
                    Change0(ptr.value);
                ptr = ptr.next;
            }
            
        }

        public void Change0(short value)
        {
            LinkedListNode ptr = head;

            while(ptr.next != null)
            {
                if(ptr.value.CompareTo(value) == 0)
                {
                    ptr.value = 0;
                }
                ptr = ptr.next;
            }
        }

        public string OutputList()
        {
            string s = "[";
            LinkedListNode ptr = head;
            while (ptr.next != null)
            {
                s += ptr.value + ", "; 
                ptr = ptr.next;  
            }
            s += ptr.value + "]";  
            return s;
        }
    }
}

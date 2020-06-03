using System;
using System.Collections.Generic;
using System.Text;

namespace laba7cs
{
    class LinkedListNode
    {
        public short value;
        public LinkedListNode next;

        public  LinkedListNode(short val, LinkedListNode nex = null)
        {
            value = val;
            next = nex;
        }
    }
}

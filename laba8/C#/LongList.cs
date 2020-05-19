using System;

namespace laba8
{
    public class LongList
    {
        private LongNode _head;  // First element of the structure 
        private LongNode _tail;  // Last element of the structure
        private int _count;  // Amount of elements in the structure

        public void Add(long data)
        {
            _count++;
            LongNode node = new LongNode(data);
            if (_head == null)  // If structure is empty
            { _head = node; }
            else
            {
                _tail.Next = node;  // Add to the end of the structure
                node.Previous = _tail;
            }
            _tail = node;
        }

        public void Delete(long data)
        {
            LongNode current = _head;
            while (current != null)
            {
                if (current.Node.Equals(data))  // Find node with user's element
                { break; }
                current = current.Next;  // Go to the next node
            }
            if (current != null)
            {
                if (current.Next != null) // Check if current isn't last
                { current.Next.Previous = current.Previous; }  // Previous node for next node will be previous node for current node
                else
                { _tail = current.Previous; }  // Previous node for current node will be a tail

                if (current.Previous != null)
                { current.Previous.Next = current.Next; }  // Next node for previous node will be next node for current node
                else
                { _head = current.Next; }  // Next node for current node will be a head
                _count--;  // if we found element in our structure
            }
            else
            { throw new Exception("There is no element in this structure"); } // if we didn't find element in our structure

        }

        public int GetPosition(long element)
        {
            int position = 1;
            if (_head.Node.Equals(element))
            { return position; }  // Position of head is 0
            else if (_tail.Node.Equals(element))
            { return _count; }  // Position of tail = count - 1
            else
            {
                LongNode current = _head;
                while (current != null)  // Find element using iteration through structure
                {
                    if (current.Node.Equals(element))
                    { return position; }
                    current = current.Next;  // Go to the next node
                    position++;
                }
            }
            throw new Exception("There is no element in this structure");  // if we didn't find element in our structure
        }

        public int FindSpecialElements()
        {
            int amount = 0;
            LongNode current = _head;
            while (current != null)  // Iterate through the structure
            {
                try
                {
                    if (current.Node % 5 == 0 && GetPosition(current.Node) % 2 == 0)  // Check special conditions from the task
                    { amount++; }
                }
                catch (Exception)  // Catch exception if there are no special elements in the structure
                {
                    return 0;
                }
                current = current.Next;  // Go to the next node
            }
            return amount;
        }

        public void DeleteGreaterAvg()
        {
            double average = 0;
            LongNode current = _head;
            while (current != null)  // Iterate through structure to calculate sum of all nodes
            {
                average += current.Node;
                current = current.Next;
            }
            average /= _count;  // Find average
            current = _head;
            while (current != null)  // Iterate through structure to find elements greater than average value and delete them
            {
                if (current.Node > average)
                { Delete(current.Node); }
                current = current.Next;
            }
        }
    }
}
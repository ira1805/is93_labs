using System;

namespace lab7
{
    class MyList
    {
        public Node FisrtElement { get; set; }

        public void AddingAfterFirstElement(int data)
        {
            var newNode = new Node { Data = data, Link = FisrtElement.Link};
            FisrtElement.Link = newNode;
        }

        public int CountOfPairedElements()
        {
            var result = 0;
            var currentPosition = 1;
            var iterator = FisrtElement;
            while (iterator.Link != null)
            {
                if (iterator.Data % 2 == 0 && currentPosition % 2 == 0)
                {
                    result++;
                }
                iterator = iterator.Link;
                currentPosition ++;
            }
            return result;
        }

        public void DeleteAfterMinELement()
        {
            var min = FisrtElement.Data;
            var index = 0;
            var iterator = FisrtElement;
            var currentPosition = 1;
            while (iterator.Link != null)
            {
                if (min > iterator.Data)
                {
                    index = currentPosition;
                }
                min = iterator.Data;
                iterator = iterator.Link;
                currentPosition++;
            }
            iterator = FisrtElement;
            for(int i = 1; i < index; i++)
            {
                iterator = iterator.Link;
            }
            iterator.Link = null;
        }

        public void Print()
        {
            var iterator = FisrtElement;
            while (iterator.Link != null) 
            {
                Console.WriteLine(iterator.Data);
                iterator = iterator.Link;
            } 
            Console.WriteLine(iterator.Data);
        }
    }
}
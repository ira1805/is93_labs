using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList()
            {
                FisrtElement = new Node { Data = 15 }
            };
            var node2 = new Node { Data = 7};
            var node3 = new Node { Data = 8};
            var node4 = new Node { Data = 9};

            list.FisrtElement.Link = node2;
            node2.Link = node3;
            node3.Link = node4;

            Console.WriteLine("Start List");
            list.Print();
            list.AddingAfterFirstElement(10);
            Console.WriteLine("List after adding element");
            list.Print();
            Console.WriteLine("List after deleting elements after min element");
            list.DeleteAfterMinELement();
            list.Print();
            Console.ReadKey();
        }
    }
}

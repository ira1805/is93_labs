using System;
using CharListNamespace;

namespace laba7_oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baranov Dmytro IS-93\n\n");
            //CharList list = new CharList();
            CharList.Node list = new CharList.Node();
            CharList.InitList("asv!skd!akka");
            Console.WriteLine(" input list content: " + CharList.OutputList() + "\n index of first <!>:  " + CharList.FindFirst('!'));
            CharList.RemoveAll('a');
            Console.WriteLine(" list content after removing all<a>:  " + CharList.OutputList() + "\n");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CharListNamespace
{
    class CharList
    {
		public static Node head = null; //head link

		public class Node //list Node class
		{
			public char data;  //Node char
			public Node next; //next Node link
		};

		public static Node AddNode(char _data)	//add Node function
		{   
			Node newNode = new Node();   //Node init
			if (head == null)  //check if there're any nodes in list
				head = newNode; //head now is new (first) Node
			newNode.data = _data;  //set data
			newNode.next = null;  //set link
			return newNode;
		}

		public static Node InitList(string line)  //list init from string
		{   
			Node li = null;
			if (line.Length == 0)   //if string is empty
				return null;
			for (int i = 0; i < line.Length; i++)
				if (i == 0) //if first Node
				{   
					head = AddNode(line[i]);    //init first Node (head)
					li = head;
				}
				else    //if Node isn't first
				{   
					li.next = AddNode(line[i]);    //set next Node link
					li = li.next;  //change variable on next Node
				}
			return head;
		}

		public static string OutputList()
		{
			string s = "";
			Node li = head;
			while (li.next != null) //until Node next link's empty
			{   
				s += li.data;  //add Node content
				li = li.next;  //change on next Node
			}
			s += li.data;  //add last Node content
			return s;
		}

		public static int FindFirst(char x)   //find the first occurrence of char in the list
		{   
			int counter = 0;
			Node li = head;
			while (li.next != null) //until the last Node in list
			{   
				if (li.data == x)  //if Node content is equal to the char
					return counter;
				li = li.next;  //change var on next Node
				counter++;  //counter increment
			}
			if (li.data == x)  //if the last Node content is equal to the char
				return counter;
			return -1;
		}

		public static void RemoveAll(char x)  //remove all Nodes with content that equals the char
		{
			Node p_li = null; //previous Node
			Node li = head;    //current Node var
			if (head == null)  //if list is empty
				return;
			while (li.next != null && li != null)   //until the last Node in list that exist
			{
				if (li.data == x)  //if Node content is equal to the char
					if (li == head) //if current Node is head
					{   
						head = li.next;    //now head's next Node of current one
						li = head;  //change var on head
					}
					else    //if current Node isn't head
					{   
						p_li.next = li.next;  //previous Node next link now is current Node next link
					}
				p_li = li;  //previous Node now is current
				li = li.next;  //current Node now is next Node of current
			}
			if (li.data == x)  //check the last Node
				p_li.next = null; //cut the last Node
		}
	}
}

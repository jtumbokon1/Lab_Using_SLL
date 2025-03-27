using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Using_SLL
{
    public class Node
    {
       public string Value { get; set; }
        public Node? Next { get; set; }

        public Node(string value)
        {
            Value = value;
        }
    }
    public class LinkedList
    {
        public Node? Head { get; private set; }
        public int Count { get; private set; }

        public LinkedList() 
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void RemoveLast()
        {
            if (Head != null)
            {
                if (Head.Next == null)
                {
                    Head = null;
                }
                else
                {
                    Node current = Head;
                    Node? next = current.Next;
                    while (next.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                }
                Count--;
            }
        }

        public void GetValue(int index) 
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            Console.WriteLine(current.Value);
        }
    }
}

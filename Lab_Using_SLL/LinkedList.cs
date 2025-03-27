using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Using_SLL
{
    public class Node
    {
        // public properties
       public string Value { get; set; }
        public Node? Next { get; set; }

        // constructor
        public Node(string value)
        {
            Value = value;
        }
    }
    public class LinkedList
    {
        // public properties
        public Node? Head { get; private set; }
        public int Count { get; private set; }

        // constructor
        public LinkedList() 
        {
            Head = null;
            Count = 0;
        }

        // public methods
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
            else
            {
                throw new InvalidOperationException();
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
                    while (current.Next!.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                }
                Count--;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public string GetValue(int index) 
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            Node? current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current?.Next;
            }
            return current!.Value;
        }
    }// class
}// namespace

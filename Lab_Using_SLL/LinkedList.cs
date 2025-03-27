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
        public Node Next { get; set; }

        public Node(string value)
        {
            Value = value;
        }
    }
    public class LinkedList
    {
        public Node? Head { get; private set; }
        public int Count { get; set; }

        public LinkedList() 
        {
            Head = null;
            Count = 0;
        }

    }
}

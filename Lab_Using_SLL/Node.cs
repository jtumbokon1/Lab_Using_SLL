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
}

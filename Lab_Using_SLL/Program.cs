/*
* Course: OOP2 CPRG-211-C
* Assignment: Lab Using Singly Linked Lists
* Author: Jirch Tumbokon
* When: Winter 2025
*
* Purpose:
*    This program implements a singly linked list with the following methods:
*    AddFirst - Adds a new node to the beginning of the list
*    AddLast - Adds a new node to the end of the list
*    RemoveFirst - Removes the first node from the list
*    RemoveLast - Removes the last node from the list
*    GetValue - Retrieves the value of a node at a given index
*/

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_Using_SLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            string[] names = {"Joe Blow", "Joe Schmoe", "John Smith",
            "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson"};

            foreach (string name in names)
            {
                linkedList.AddLast(name); // Populate the linked list with names
            }

            Console.WriteLine("Linked list after adding to first:");
            linkedList.AddFirst("New First");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList.GetValue(i));
            }

            Console.WriteLine("\nLinked list after adding to last:");
            linkedList.AddLast("New Last");
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList.GetValue(i));
            }

            Console.WriteLine("\nLinked list after removing first:");
            linkedList.RemoveFirst();
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList.GetValue(i));
            }

            Console.WriteLine("\nLinked list after removing last:");
            linkedList.RemoveLast();
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList.GetValue(i));
            }

            Console.WriteLine("\nRetrieving the value of a given index:");
            Console.WriteLine(linkedList.GetValue(3));
        }
    }// class
}// namespace

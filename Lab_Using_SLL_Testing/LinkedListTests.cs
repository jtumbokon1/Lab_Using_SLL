using System.Collections.Generic;
using Lab_Using_SLL;

namespace Lab_Using_SLL_Testing
{


    //Removing the last node in the list

    //Retrieving the value of a node at a given index

    //Determining the size of the list
    public class LinkedListTests
    {
        public LinkedList? tests;

        [SetUp]
        public void Setup()
        {
            tests = new LinkedList();

            string[] names = {"Joe Blow", "Joe Schmoe", "John Smith",
            "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson"};

            foreach (string name in names)
            {
                tests.AddLast(name); // Adds names to the end of the list
            }
        }

        [TearDown]
        public void TearDown()
        {
            tests = null;
        }

        [Test]
        public void Test_AddFirst()
        {
            tests?.AddFirst("New First");

            Assert.That(tests?.Count, Is.EqualTo(8));
            Assert.That(tests?.Head?.Value, Is.EqualTo("New First"));
        }

        [Test]
        public void Test_AddLast()
        {
            tests?.AddLast("New Last");

            Assert.That(tests?.Count, Is.EqualTo(8));
            Assert.That(tests?.GetValue(7), Is.EqualTo("New Last"));

        }

        [Test]
        public void Test_RemoveFirst()
        {
            tests?.RemoveFirst();

            Assert.That(tests?.Count, Is.EqualTo(6));
            Assert.That(tests?.Head?.Value, Is.EqualTo("Joe Schmoe"));
        }

        [Test]
        public void Test_RemoveLast()
        {
            tests?.RemoveLast();

            Assert.That(tests?.Count, Is.EqualTo(6));
            Assert.That(tests?.GetValue(5), Is.EqualTo("Sam Sammerson"));
        }

        [Test]
        public void Test_GetValue()
        {
            tests?.GetValue(0);

            Assert.That(tests?.GetValue(0), Is.EqualTo("Joe Blow"));
        }

        [Test]
        public void RemoveFirst_ThrowsExceptionOnEmptyList()
        {
            LinkedList emptyList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => emptyList.RemoveFirst());
        }

        [Test]
        public void RemoveLast_ThrowsExceptionOnEmptyList()
        {
            LinkedList emptyList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => emptyList.RemoveLast());
        }

        [Test]
        public void GetValue_ThrowsExceptionForInvalidIndex()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => tests?.GetValue(10));
        }
    }
}
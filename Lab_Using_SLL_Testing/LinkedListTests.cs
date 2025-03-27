using System.Collections.Generic;
using Lab_Using_SLL;

namespace Lab_Using_SLL_Testing
{
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
                tests.AddLast(name); // Populate the linked list with names
            }
        }

        [TearDown]
        public void TearDown()
        {
            tests = null;
        }

        [Test]
        // Test to add a new element to the beginning of the list
        public void Test_AddFirst()
        {
            tests?.AddFirst("New First");

            Assert.That(tests?.Count, Is.EqualTo(8));
            Assert.That(tests?.Head?.Value, Is.EqualTo("New First"));
        }

        [Test]
        // Test to add a new element to the end of the list
        public void Test_AddLast()
        {
            tests?.AddLast("New Last");

            Assert.That(tests?.Count, Is.EqualTo(8));
            Assert.That(tests?.GetValue(7), Is.EqualTo("New Last"));

        }

        [Test]
        // Test to remove the first element from the list
        public void Test_RemoveFirst()
        {
            tests?.RemoveFirst();

            Assert.That(tests?.Count, Is.EqualTo(6));
            Assert.That(tests?.Head?.Value, Is.EqualTo("Joe Schmoe"));
        }

        [Test]
        // Test to remove the last element from the list
        public void Test_RemoveLast()
        {
            tests?.RemoveLast();

            Assert.That(tests?.Count, Is.EqualTo(6));
            Assert.That(tests?.GetValue(5), Is.EqualTo("Sam Sammerson"));
        }

        [Test]
        // Test to get value of a certain index
        public void Test_GetValue()
        {
            tests?.GetValue(0);

            Assert.That(tests?.GetValue(0), Is.EqualTo("Joe Blow"));
        }

        [Test]
        // Test to determine the size of the list
        public void Test_GetListSize()
        {
            Assert.That(tests?.Count, Is.EqualTo(7));
        }

        [Test]
        // Test that an exception is thrown when trying to get the value of an index that is out of range
        public void Test_GetValue_ThrowsExceptionOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => tests?.GetValue(10));
        }

        [Test]
        // Test that an exception is thrown when trying to remove the first element from an empty list
        public void Test_RemoveFirst_ThrowsExceptionOnEmptyList()
        {
            LinkedList emptyList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => emptyList.RemoveFirst());
        }

        [Test]
        // Test that an exception is thrown when trying to remove the last element from an empty list
        public void Test_RemoveLast_ThrowsExceptionOnEmptyList()
        {
            LinkedList emptyList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => emptyList.RemoveLast());
        }

        [Test]
        // Test that an exception is thrown when trying to get the value of an index that is on an empty list
        public void Test_GetValue_ThrowsExceptionOnEmptyList()
        {
            LinkedList emptyList = new LinkedList();

            Assert.Throws<ArgumentOutOfRangeException>(() => emptyList.GetValue(0));
        }
    }// class
}// namespace
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    class MyStackTests
    {
        private MyStack<string> stack;
        [SetUp]
        public void Setup()
        {
            stack = new MyStack<string>();
            ;
        }

        public void Teardown()
        {
            stack.Dispose();
            stack = null;
        }

        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            Assert.That(stack.IsEmpty, Is.EqualTo(true));
        }

        
        [Test]
        public void Count_PushTwoItems_ReturnsTwo()
        {
            stack.Push("Hello");
            stack.Push("World");
            Assert.That(stack.IsEmpty, Is.EqualTo(false));
            Assert.That(stack.Count, Is.EqualTo(2));
        }


        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Push_Item_AddsItemAtTheEndOfStack()
        {
            stack.Push("Microsoft");
            Assert.That(stack.Count, Is.EqualTo(1));
            Assert.That(stack.Peek(), Is.EqualTo("microsoft").IgnoreCase);           
        }

        [Test]
        public void Pop_Item_RemoveFromEndOfStack()
        {
            stack.Push("Hello");
            stack.Push("World");
            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(1));
            Assert.That(stack.Peek(), Is.EqualTo("hello").IgnoreCase);
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsItemAtTheEndOfStack()
        {
            stack.Push("Hello");
            stack.Push("World");
            Assert.That(stack.Peek, Is.EqualTo("world").IgnoreCase);
        }
    }
}

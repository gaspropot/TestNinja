using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        public Fundamentals.Stack<object> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Fundamentals.Stack<object>();
        }

        [Test]
        public void Push_ObjectIsNull_ThrowArguementNullException()
        {
            //both work
            Assert.Throws<ArgumentNullException>(() => _stack.Push(null));
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase("test1")]
        [TestCase("test2")]
        [TestCase("test3")]
        public void Push_ObjectIsNotNull_ObjectIsAddedToTheList(string test)
        {
            _stack.Push(test);
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_ListCountIsZero_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Test]
        [TestCase("test1", "test2", "test3")]
        [TestCase("test4", "test5", "test6")]
        [TestCase("test7", "test8", "test9")]
        public void Pop_ListCountIsNotZero_LastItemIsRemoved(string firstItem, string secondItem, string lastItem)
        {
            _stack.Push(firstItem);
            _stack.Push(secondItem);
            _stack.Push(lastItem);

            int initialCount = _stack.Count;
            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(initialCount - 1));
        }

        [Test]
        [TestCase("test1", "test2", "test3")]
        [TestCase("test4", "test5", "test6")]
        [TestCase("test7", "test8", "test9")]
        public void Pop_ListCountIsNotZero_ReturnLastItem(string firstItem, string secondItem, string lastItem)
        {
            _stack.Push(firstItem);
            _stack.Push(secondItem);
            _stack.Push(lastItem);

            Assert.That(() => _stack.Pop(), Is.EqualTo(lastItem));
        }

        [Test]
        public void Peek_ListCountIsZero_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Peek());
        }

        [Test]
        [TestCase("test1", "test2", "test3")]
        [TestCase("test4", "test5", "test6")]
        [TestCase("test7", "test8", "test9")]
        public void Peek_ListCountIsNotZero_ReturnsLastItem(string firstItem, string secondItem, string lastItem)
        {
            _stack.Push(firstItem);
            _stack.Push(secondItem);
            _stack.Push(lastItem);

            Assert.That(() => _stack.Peek(), Is.EqualTo(lastItem));
        }

        [Test]
        [TestCase("test1", "test2", "test3")]
        [TestCase("test4", "test5", "test6")]
        [TestCase("test7", "test8", "test9")]
        public void Peek_ListCountIsNotZero_DoesNotRemoveObjectOnTop(string firstItem, string secondItem, string lastItem)
        {
            _stack.Push(firstItem);
            _stack.Push(secondItem);
            _stack.Push(lastItem);

            int initialCount = _stack.Count;
            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(initialCount));
        }
    }
}

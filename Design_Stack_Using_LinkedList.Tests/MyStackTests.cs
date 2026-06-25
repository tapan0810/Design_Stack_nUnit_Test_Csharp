using NUnit.Framework;

namespace Design_Stack_Using_LinkedList.Tests
{
    public class MyStackTests
    {
        private MyStack stack;

        [SetUp]
        public void Setup()
        {
            stack = new MyStack();
        }

        [Test]
        public void Empty_NewStack_ReturnsTrue()
        {
            Assert.That(stack.Empty(), Is.True);
        }

        [Test]
        public void Push_Element_MakesStackNonEmpty()
        {
            stack.Push(10);

            Assert.That(stack.Empty(), Is.False);
        }

        [Test]
        public void Top_ReturnsLastPushedElement()
        {
            stack.Push(10);
            stack.Push(20);

            Assert.That(stack.top(), Is.EqualTo(20));
        }

        [Test]
        public void Pop_ReturnsLastPushedElement()
        {
            stack.Push(10);
            stack.Push(20);

            int result = stack.pop();

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Pop_RemovesTopElement()
        {
            stack.Push(10);
            stack.Push(20);

            stack.pop();

            Assert.That(stack.top(), Is.EqualTo(10));
        }
    }
}
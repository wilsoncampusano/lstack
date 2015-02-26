using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lstack;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        private MStack _stack;

        [TestInitialize]
        public void WithANewStackCreated()
        {
            _stack = MStack.create(3);
        }

        [TestMethod ] [ExpectedException(typeof(LessThanZeroCapacity))]
        public void CanNotCreateANewStackWithLessThanZeroCapacity()
        {
            _stack = MStack.create(-1);
        }

        [TestMethod]
        public void CanCreateANewStackObjectWithACapacity()
        {
            Assert.AreEqual(3, _stack.getCapacity());
        }

        [TestMethod]
        public void CanKnowWhenTheStackIsEmpty()
        {
            Assert.IsTrue(_stack.IsEmpty());
        }

        [TestMethod]
        public void WhenPushingX_SizeShouldIncrementByOne()
        {
            _stack.Push(0);
            Assert.AreEqual(1, _stack.Size());
        }

        [TestMethod]
        public void WhenPopingAfterPushing_SizeShouldBeZero()
        {
            _stack.Push(9);

            Assert.AreEqual(9, _stack.Pop());
            Assert.IsTrue(_stack.IsEmpty());
            Assert.AreEqual(0, _stack.Size());
        }

        [TestMethod]
        public void CanPushXOnTheStackAndPopX()
        {
            _stack.Push(00);
            Assert.AreEqual(00, _stack.Pop());
        }
        
        [TestMethod]
        public void WhenPushXAndY_ItPopYAndX()
        {
            _stack.Push(55);
            _stack.Push(66);

            Assert.AreEqual(66, _stack.Pop());
            Assert.AreEqual(55,_stack.Pop());
        }
    }
}

using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LstackTest
{
    [TestClass]
    public class StackTest
    {

        [TestMethod]
        public void CanCreateANewStack()
        {
            MStack _stack = new MStack();
            Assert.IsNotNull(_stack);
        }
    }

    
}

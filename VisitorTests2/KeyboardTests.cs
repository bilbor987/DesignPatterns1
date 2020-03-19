using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Visitor.Tests
{
    [TestClass()]
    public class KeyboardTests
    {
        [TestMethod()]
        public void AcceptTest()
        {
            Keyboard keyboard = new Keyboard();
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();

            keyboard.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(keyboard), Times.Once());
        }

        [TestMethod()]
        public void SameInstanceOfKeyboard_EqualsTrue()
        {
            Keyboard keyboard1 = new Keyboard();

            Assert.IsTrue(keyboard1.Equals(keyboard1));
        }

        [TestMethod()]
        public void CompareKeyboardWithNull_EqualsFalse()
        {
            Keyboard keyboard1 = new Keyboard();

            Assert.IsFalse(keyboard1.Equals(null));
        }

        [TestMethod()]
        public void DifferentKeyboardObjects_EqualsFalse()
        {
            Keyboard keyboard1 = new Keyboard();
            Keyboard keyboard2 = new Keyboard();

            Assert.IsFalse(keyboard1.Equals(keyboard2));
        }

        [TestMethod()]
        public void CompareKeyboardWithOtherObject_EqualsFalse()
        {
            Keyboard keyboard = new Keyboard();
            Mock<IComputerPart> mockComputerPart = new Mock<IComputerPart>();

            Assert.IsFalse(keyboard.Equals(mockComputerPart.Object));
        }

        [TestMethod()]
        public void SameInstanceOfKeyboard_HashCodeTrue()
        {
            Keyboard keyboard = new Keyboard();

            Assert.IsTrue(keyboard.GetHashCode() == keyboard.GetHashCode());
        }

        [TestMethod()]
        public void DifferentInstancesOfKeyboard_HashCodeFalse()
        {
            Keyboard keyboard1= new Keyboard();
            Keyboard keyboard2 = new Keyboard();

            Assert.IsFalse(keyboard1.GetHashCode() == keyboard2.GetHashCode());
        }
    }
}
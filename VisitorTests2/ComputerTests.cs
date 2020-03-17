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
    public class ComputerTests
    {
        [TestMethod()]
        public void AcceptTestVisitor_VisitCalledOnceForComputerNeverForComputerParts()
        {
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();
            
            Computer computer = new Computer();
            computer.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(computer), Times.Once());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Mouse>()), Times.Never());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Keyboard>()), Times.Never());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Monitor>()), Times.Never());
        }

        [TestMethod()]
        public void AcceptTestVisitor_VisitCalledOnceForComputerOnceForComputerParts()
        {
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();
            Computer computer = new Computer(new List<IComputerPart>() {new Mouse(), new Monitor(), new Keyboard() });

            computer.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(computer), Times.Once());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Mouse>()), Times.Once());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Keyboard>()), Times.Once());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Monitor>()), Times.Once());
        }

        [TestMethod()]
        public void AcceptTestVisitor_VisitCalledOnceForComputerTwiceForComputerParts()
        {
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();
            Computer computer = new Computer(new List<IComputerPart>() { new Mouse(), new Monitor(), new Keyboard() });
            computer.AddComputerPart(new Monitor());
            computer.AddComputerPart(new Mouse());
            computer.AddComputerPart(new Keyboard());
            computer.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(computer), Times.Once());
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Mouse>()), Times.Exactly(2));
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Keyboard>()), Times.Exactly(2));
            mockComputerPartVisitor.Verify(visitor => visitor.Visit(It.IsAny<Monitor>()), Times.Exactly(2));
        }
        [TestMethod()]
        public void AddComponentPartTest()
        {
            Mouse mouse = new Mouse();
            Keyboard keyboard = new Keyboard();
            Computer computerActual = new Computer();

            computerActual.AddComputerPart(mouse);
            computerActual.AddComputerPart(keyboard);

            Computer computerExpected = new Computer(new List<IComputerPart>() { mouse , keyboard});

            Assert.AreEqual(computerExpected, computerActual);
        }

        [TestMethod()]
        public void SameInstanceComputer_Equals_True()
        {
            Computer computer = new Computer();

            Assert.IsTrue(computer.Equals(computer));
        }

        [TestMethod()]
        public void Computer_EqualsNull_False()
        {
            Computer computer = new Computer();

            Assert.IsFalse(computer.Equals(null));
        }

        [TestMethod()]
        public void DifferentComputers_Equals_False()
        {
            Computer computer1 = new Computer(new List<IComputerPart>() { new Mouse()});
            Computer computer2 = new Computer();

            Assert.IsFalse(computer1.Equals(computer2));
        }

        [TestMethod()]
        public void CompareComputerWithOtherObject_Equals_False()
        {
            Computer computer = new Computer();
            Mouse mouse = new Mouse();

            Assert.IsFalse(computer.Equals(mouse));
        }

    }
}
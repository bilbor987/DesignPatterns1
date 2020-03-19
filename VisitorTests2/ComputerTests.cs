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
            mockComputerPartVisitor.VerifyNoOtherCalls();
        }

        [TestMethod()]
        public void AcceptTestVisitor_VisitCalledOnceForComputerOnceForComputerParts()
        {
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();
            Mock<IComputerPart> mockComputerPart = new Mock<IComputerPart>();
            
            Computer computer = new Computer(new List<IComputerPart>(){ mockComputerPart.Object});
            computer.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(computer), Times.Once());
            mockComputerPart.Verify(x => x.Accept(mockComputerPartVisitor.Object), Times.Once());
        }

        [TestMethod()]
        public void AcceptTestVisitor_VisitCalledOnceForComputerTwiceForComputerParts()
        {
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();
            Mock<IComputerPart> mockComputerPart1 = new Mock<IComputerPart>();
            Mock<IComputerPart> mockComputerPart2 = new Mock<IComputerPart>();

            Computer computer = new Computer(new List<IComputerPart>() { mockComputerPart1.Object, mockComputerPart2.Object });

            computer.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(computer), Times.Once());
            mockComputerPart1.Verify(x => x.Accept(mockComputerPartVisitor.Object), Times.Once());
            mockComputerPart2.Verify(x => x.Accept(mockComputerPartVisitor.Object), Times.Once());
        }
        //TODO implement UT for concrete visitors/any class
        //TODO use Tools/Test line coverage in VS (run with coverage)
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
            Computer computer1 = new Computer(new List<IComputerPart>() { new Mock<IComputerPart>().Object });
            Computer computer2 = new Computer();

            Assert.IsFalse(computer1.Equals(computer2));
        }

        [TestMethod()]
        public void CompareComputerWithOtherObject_Equals_False()
        {
            Computer computer = new Computer();

            Assert.IsFalse(computer.Equals(new Mock<IComputerPart>().Object));
        }

        [TestMethod()]
        public void TwoComputersSameValues_GetHashCode_True()
        {
            Mouse mouse = new Mouse();
            Mock<IComputerPart> mockComputerPart = new Mock<IComputerPart>();
            Computer computer1 = new Computer(new List<IComputerPart>() { mockComputerPart.Object });
            Computer computer2 = new Computer(new List<IComputerPart>() { mockComputerPart.Object });

            Assert.IsTrue(computer1.GetHashCode() == computer2.GetHashCode());
        }

        [TestMethod()]
        public void TwoComputerDifferentValues_GetHashCode_False()
        {
            Computer computer1 = new Computer(new List<IComputerPart>() { new Mock<IComputerPart>().Object });
            Computer computer2 = new Computer();

            Assert.IsFalse(computer1.GetHashCode() == computer2.GetHashCode());
        }

        [TestMethod()]
        public void EqualsOperatorTest_ComputerObjectsAreEqual()
        {
            Computer computer1 = new Computer();
            Computer computer2 = new Computer();

            Assert.IsTrue(computer1 == computer2);
            Assert.IsFalse(computer1 != computer2);
        }

        [TestMethod()]
        public void EqualsOperatorTest_ComputerObjectsAreDifferent()
        {
            Computer computer1 = new Computer();
            Computer computer2 = new Computer(new List<IComputerPart>() { new Mock<IComputerPart>().Object });

            Assert.IsTrue(computer1 != computer2);
            Assert.IsFalse(computer1 == computer2);
        }

        [TestMethod()]
        public void EqualsOperatorTest_ComputerObjectsReferenceTheSameObject()
        {
            Computer computer1 = new Computer();
            Computer computer2 = computer1;

            Assert.IsTrue(computer1 == computer2);
            Assert.IsFalse(computer1 != computer2);
        }

        [TestMethod()]
        public void EqualsOperatorTest_OneOfComputerObjectIsNull()
        {
            Computer computer1 = new Computer();
            Computer computer2 = null;

            Assert.IsTrue(computer1 != computer2);
            Assert.IsFalse(computer1 == computer2);
        }

        [TestMethod()]
        public void EqualsOperatorTest_ComputerObjectsAreEqual_ComputerPartsListIsTheSame()
        {
            List<IComputerPart> computerParts = new List<IComputerPart>() { new Mock<IComputerPart>().Object };
            Computer computer1 = new Computer(computerParts);
            Computer computer2 = new Computer(computerParts);

            Assert.IsTrue(computer1 == computer2);
            Assert.IsFalse(computer1 != computer2);
        }

        [TestMethod()]
        public void EqualsOperatorTest_ComputerObjectsAreNotEqual_ComputerPartsListIsDifferent()
        {
            List<IComputerPart> computerParts1 = new List<IComputerPart>() { new Mock<IComputerPart>().Object };
            List<IComputerPart> computerParts2 = new List<IComputerPart>() { new Mock<IComputerPart>().Object };
            Computer computer1 = new Computer(computerParts1);
            Computer computer2 = new Computer(computerParts2);

            Assert.IsTrue(computer1 != computer2);
            Assert.IsFalse(computer1 == computer2);
        }

    }
}
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
    public class MouseTests
    {
        [TestMethod()]
        public void AcceptTest()
        {
            Mouse mouse = new Mouse();
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();

            mouse.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(mouse), Times.Once());
        }
    }
}
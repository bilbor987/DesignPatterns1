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
    public class MonitorTests
    {
        [TestMethod()]
        public void AcceptTest()
        {
            Monitor monitor = new Monitor();
            Mock<IComputerPartVisitor> mockComputerPartVisitor = new Mock<IComputerPartVisitor>();

            monitor.Accept(mockComputerPartVisitor.Object);

            mockComputerPartVisitor.Verify(visitor => visitor.Visit(monitor), Times.Once());
        }
    }
}
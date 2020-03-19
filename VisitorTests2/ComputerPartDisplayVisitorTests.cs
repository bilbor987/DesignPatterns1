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
    public class ComputerPartDisplayVisitorTests
    {
        [TestMethod()]
        public void VisitComputerTest_Once()
        {
            ComputerPartDisplayVisitor computerPartDisplayVisitor = new ComputerPartDisplayVisitor();
            Mock<Computer> mockComputerPart = new Mock<Computer>();

            computerPartDisplayVisitor.Visit(mockComputerPart.Object);           
            //mockComputerPart.Verify(m => m.Accept(computerPartDisplayVisitor), Times.Once());

            
        }
    }
}
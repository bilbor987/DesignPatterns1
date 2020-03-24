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
    public class RepairPartVisitorTests
    {
        [TestMethod()]
        public void VisitComputerTest()
        {
            Mock<IDisplay> mockDisplay = new Mock<IDisplay>();
            RepairPartVisitor computerPartDisplayVisitor = new RepairPartVisitor(mockDisplay.Object);
            Computer computer = new Computer();

            computerPartDisplayVisitor.Visit(computer);
            mockDisplay.Verify(x => x.WriteLine("Repair Computer"), Times.Once());
        }

        [TestMethod()]
        public void VisitMouseTest()
        {
            Mock<IDisplay> mockDisplay = new Mock<IDisplay>();
            RepairPartVisitor computerPartDisplayVisitor = new RepairPartVisitor(mockDisplay.Object);
            Mouse mouse = new Mouse();

            computerPartDisplayVisitor.Visit(mouse);
            mockDisplay.Verify(x => x.WriteLine("Repair mouse"), Times.Once());
        }

        [TestMethod()]
        public void VisitKeyboardTest()
        {
            Mock<IDisplay> mockDisplay = new Mock<IDisplay>();
            RepairPartVisitor computerPartDisplayVisitor = new RepairPartVisitor(mockDisplay.Object);
            Keyboard keyboard = new Keyboard();

            computerPartDisplayVisitor.Visit(keyboard);
            mockDisplay.Verify(x => x.WriteLine("Repair keyboard"), Times.Once());
        }

        [TestMethod()]
        public void VisitMonitorTest()
        {
            Mock<IDisplay> mockDisplay = new Mock<IDisplay>();
            RepairPartVisitor computerPartDisplayVisitor = new RepairPartVisitor(mockDisplay.Object);
            Monitor monitor = new Monitor();

            computerPartDisplayVisitor.Visit(monitor);
            mockDisplay.Verify(x => x.WriteLine("Repair monitor"), Times.Once());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Tests
{
    [TestClass()]
    public class VisitorFactoryTests
    {
        VisitorFactory visitorFactory = new VisitorFactory();
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetVisitorTest_InvalidNameOfVisitor_Throws_ArgumentException()
        {
            visitorFactory.GetVisitor("this_should_throw_an_exception", "display");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetVisitorTest_InvalidNameOfDisplayMethod_Throws_ArgumentException()
        {
            visitorFactory.GetVisitor("repair", "this_should_throw_an_exception");
        }

        [TestMethod()]
        public void GetVisitorTest_ContainsDisplay_ReturnsComputerPartDisplayVisitor()
        {
            var computerPartDisplayVisitor = visitorFactory.GetVisitor("dDDiSplayyy", "display");
            Assert.IsNotNull(computerPartDisplayVisitor);
            Assert.IsInstanceOfType(computerPartDisplayVisitor, typeof(ComputerPartDisplayVisitor));
        }

        [TestMethod()]
        public void GetVisitorTest_ContainsRepair_ReturnsRepairPartVisitor()
        {
            var repairPartVisitor = visitorFactory.GetVisitor("rePair", "display");
            Assert.IsNotNull(repairPartVisitor);
            Assert.IsInstanceOfType(repairPartVisitor, typeof(RepairPartVisitor));
        }
    }
}
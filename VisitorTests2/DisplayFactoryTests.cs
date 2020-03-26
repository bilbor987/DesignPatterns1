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
    public class DisplayFactoryTests
    {
        DisplayFactory displayFactory = new DisplayFactory();
        [TestMethod()]
        public void GetDisplayTest_ContainsDisplay_ReturnsDisplayer()
        {
            var displayer = displayFactory.GetDisplay("ddDisplayyyy");
            Assert.IsNotNull(displayer);
            Assert.IsInstanceOfType(displayer, typeof(Displayer));
        }

        [TestMethod()]
        public void GetDisplayTest_ContainsFile_ReturnsFileWriter()
        {
            var fileWriter = displayFactory.GetDisplay("ffiLe");
            Assert.IsNotNull(fileWriter);
            Assert.IsInstanceOfType(fileWriter, typeof(FileWriter));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetDisplayTest_Throws_ArgumentException()
        {
            displayFactory.GetDisplay("this_should_throw_exception");
        }
    }
}
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
    public class DisplayerTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {
            Displayer displayer = new Displayer();
            string messageToBeWritten = "Bogdan";

            displayer.WriteLine(messageToBeWritten);

            Assert.IsTrue(messageToBeWritten == displayer.Message);
            
        }
    }
}
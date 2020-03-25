using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileUtils;

namespace Visitor.Tests
{
    [TestClass()]
    public class FileWriterTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {
            FileWriter fileWriter = new FileWriter();
            string message = "expected message";
            string expectedFileName = "\\expected.txt";
            string actualFileName = "\\WriteText.txt";
            string currentDir = Environment.CurrentDirectory;

            string pathOfExpectedFile = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(currentDir))) + expectedFileName;
            string pathOfActualFile = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(currentDir))) + actualFileName;

            File.WriteAllText(pathOfActualFile, string.Empty);
            fileWriter.WriteLine(message);

            Assert.IsTrue(CustomPaths.FileCompare(pathOfExpectedFile, pathOfActualFile));
            File.WriteAllText(pathOfActualFile, string.Empty);

        }

    }
}
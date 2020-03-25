using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class FileWriter : IDisplay
    {
        public void WriteLine(string message)
        {
            string fileName = "\\WriteText.txt";
            string currentDir = Environment.CurrentDirectory;
            string myPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(currentDir))) + fileName;

            Console.WriteLine(myPath);

            using (StreamWriter file = new StreamWriter(myPath, true))
            {
                file.WriteLine(message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * bool filesAreEqual = new FileInfo(path1).Length == new FileInfo(path2).Length && 
       File.ReadAllBytes(path1).SequenceEqual(File.ReadAllBytes(path2));
 *
 */


namespace Visitor
{
    public class FileWriter : IDisplay
    {
        public void WriteLine(string message)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\pocol\source\DesignPatterns\DesignPatterns\WriteText.txt", true))
            {
                file.WriteLine(message);
            }
        }
    }
}

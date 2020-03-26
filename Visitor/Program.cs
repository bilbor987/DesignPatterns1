using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileUtils;

namespace Visitor
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            IComputerPartVisitorFactory computerPartVisitorFactory = new VisitorFactory();
            IComputerPartVisitor displayVisitor = computerPartVisitorFactory.GetVisitor("display", "display");
            IComputerPartVisitor repairVisitor = computerPartVisitorFactory.GetVisitor("repair", "file");

            DoStuff(displayVisitor);
            DoStuff(repairVisitor);
        }

        private static void DoStuff(IComputerPartVisitor visitor)
        {
            IComputerPart[,] parts = new IComputerPart[,] { { new Computer(), new Keyboard() }, { new Mouse(), new Computer() } };

            foreach (var part in parts)
            {
                part.Accept(visitor);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerPartVisitor displayVisitor = new ComputerPartDisplayVisitor();
            IComputerPartVisitor repairVisitor = new RepairPartVisitor();
            DoStuff(displayVisitor);
            DoStuff(repairVisitor);
        }

        private static void DoStuff(IComputerPartVisitor visitor)
        {
            IComputerPart[,] parts = new IComputerPart[,] { { new Computer(), new Keyboard() }, { new Mouse(), new Computer() } };

            foreach (var part in parts)
            {
                part.Accept(visitor);
                //Console.WriteLine("\n");
            }
        }
    }
}

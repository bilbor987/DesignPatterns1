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
            List<IComputerPart> parts = new List<IComputerPart>() { new Computer(), new Computer(), new Computer() };

            foreach (var part in parts)
            {
                part.Accept(visitor);
                Console.WriteLine("\n");
            }
        }
    }
}

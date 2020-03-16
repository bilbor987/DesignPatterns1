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
            ComputerPartDisplayVisitor displayVisitor = new ComputerPartDisplayVisitor();
            RepairPartVisitor repairVisitor = new RepairPartVisitor();
            List<IComputerPart> parts = new List<IComputerPart>() { new Computer(), new Computer(), new Computer() };

            foreach (var part in parts)
            {
                part.Accept(displayVisitor);
                Console.WriteLine("\n");
                part.Accept(repairVisitor);
            }
            
            Console.ReadKey();
        }
    }
}

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
            IDisplay display = new Displayer();
            IDisplay fileWriter = new FileWriter();
            IComputerPartVisitor displayVisitor = new ComputerPartDisplayVisitor(display);
            IComputerPartVisitor repairVisitor = new RepairPartVisitor(fileWriter);
            DoStuff(displayVisitor);
            DoStuff(repairVisitor);

            

     
        }

        private static void DoStuff(IComputerPartVisitor visitor)
        {
            //pe computer nu mai afiseaza pe ecran! as expected, totu e in regula
            IComputerPart[,] parts = new IComputerPart[,] { { new Computer(), new Keyboard() }, { new Mouse(), new Computer() } };

            foreach (var part in parts)
            {
                part.Accept(visitor);
            }
        }
    }
}

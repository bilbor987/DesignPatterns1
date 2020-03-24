using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        private IDisplay display;
        public ComputerPartDisplayVisitor(IDisplay display) 
        {
            this.display = display;
        }

        public void Visit(Computer computer)
        {
            display.WriteLine("Displaying computer");
        }

        public void Visit(Mouse mouse)
        {
            display.WriteLine("Displaying mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            display.WriteLine("Displaying keyboard");
        }

        public void Visit(Monitor monitor)
        {
            display.WriteLine("Displaying monitor");
        }
    }
}

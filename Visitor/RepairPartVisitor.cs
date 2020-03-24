using System;

namespace Visitor
{
    public class RepairPartVisitor : IComputerPartVisitor
    {
        private IDisplay display;
        public RepairPartVisitor(IDisplay display)
        {
            this.display = display;
        }

        public void Visit(Computer computer)
        {
            display.WriteLine("Repair Computer");
        }

        public void Visit(Mouse mouse)
        {
            display.WriteLine("Repair mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            display.WriteLine("Repair keyboard");
        }

        public void Visit(Monitor monitor)
        {
            display.WriteLine("Repair monitor");
        }
    }
}
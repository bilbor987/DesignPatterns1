using System;

namespace Visitor
{
    class RepairPartVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Repair Computer:");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Repair mouse:");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Repair keyboard:");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Repair monitor:");
        }
    }
}
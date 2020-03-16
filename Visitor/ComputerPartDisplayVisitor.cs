﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying computer:");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying mouse:");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying keyboard:");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying monitor:");
        }
    }
}

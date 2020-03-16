using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}

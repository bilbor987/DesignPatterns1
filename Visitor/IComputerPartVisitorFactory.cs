using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IComputerPartVisitorFactory
    {
        IComputerPartVisitor GetVisitor(string name, string displayMethod);
    }
}

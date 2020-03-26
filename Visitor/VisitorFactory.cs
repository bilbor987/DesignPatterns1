using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class VisitorFactory : IComputerPartVisitorFactory
    {
        public IComputerPartVisitor GetVisitor(string nameOfVisitor, string nameOfDisplayMethod)
        {
            DisplayFactory displayFactory = new DisplayFactory();
            if (nameOfVisitor.ToLower().Contains("display")) { return new ComputerPartDisplayVisitor(displayFactory.GetDisplay(nameOfDisplayMethod)); }
            else if (nameOfVisitor.ToLower().Contains("repair")) { return new RepairPartVisitor(displayFactory.GetDisplay(nameOfDisplayMethod)); }
            else throw new ArgumentException("Invalid visitor choice");
        }
    }
}

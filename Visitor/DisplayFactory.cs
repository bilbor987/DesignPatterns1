using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class DisplayFactory : IDisplayFactory
    {
        public IDisplay GetDisplay(string displayMethod)
        {
            if (displayMethod.ToLower().Contains("display")) { return new Displayer(); }
            else if (displayMethod.ToLower().Contains("file")) { return new FileWriter(); }
            else throw new ArgumentException("Invalid display choice");
        }
    }
}

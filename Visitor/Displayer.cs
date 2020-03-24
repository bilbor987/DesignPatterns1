using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Displayer : IDisplay
    {
        public string Message { get; set; }

        public void WriteLine(string message)
        {
            Message = message;
        }

    }
}

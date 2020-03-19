﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IConsole
    {
        void Write(string message);
        void WriteLine(string message);
        string ReadLine();
    }
}
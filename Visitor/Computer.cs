using System;
using System.Collections.Generic;

namespace Visitor
{
    public class Computer : IComputerPart
    {
        static int ComputerID = 1;
        List<IComputerPart> parts;

        public Computer()
        {
            parts = new List<IComputerPart>() { new Mouse(), new Keyboard(), new Monitor() };
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (var part in parts)
            {
                Console.WriteLine($"Computer no:{ComputerID}");
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
            ComputerID++;
        }
    }
}
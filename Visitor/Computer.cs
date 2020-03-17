using System;
using System.Collections.Generic;
using System.Linq;

namespace Visitor
{
    public class Computer : IComputerPart
    {

        private List<IComputerPart> computerParts = new List<IComputerPart>();

        public Computer(List<IComputerPart> cp)
        {
            computerParts = cp;
        }

        public Computer() { }

        public void AddComputerPart(IComputerPart cp)
        {
            computerParts.Add(cp);
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (var part in computerParts)
            {
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Computer))
            {
                return false;
            }
            var inFirstNotInSecond = this.computerParts.Except(((Computer)obj).computerParts);
            var inSecondNotInFirst = ((Computer)obj).computerParts.Except(this.computerParts);

            if (inFirstNotInSecond.Count() == 0 &&
                inSecondNotInFirst.Count() == 0)
                return true;

            return false;
        }

    }
}
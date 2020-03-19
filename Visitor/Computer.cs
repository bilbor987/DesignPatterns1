using System;
using System.Collections.Generic;
using System.Linq;

namespace Visitor
{
    public class Computer : IComputerPart
    {

        private IList<IComputerPart> computerPartsreadOnly;

        public Computer(List<IComputerPart> cp)
        {
            computerPartsreadOnly = new List<IComputerPart>(cp).AsReadOnly();
        }

        public Computer()
        {
            computerPartsreadOnly = new List<IComputerPart>().AsReadOnly();
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (var part in computerPartsreadOnly)
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
            var inFirstNotInSecond = this.computerPartsreadOnly.Except(((Computer)obj).computerPartsreadOnly);
            var inSecondNotInFirst = ((Computer)obj).computerPartsreadOnly.Except(this.computerPartsreadOnly);

            if (inFirstNotInSecond.Count() == 0 &&
                inSecondNotInFirst.Count() == 0)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            foreach(var part in computerPartsreadOnly)
            {
                hash = hash * 31 + part.GetHashCode();
            }
            return hash;
        }

        public static bool operator ==(Computer left, Computer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Computer left, Computer right)
        {
            return !(left == right);
        }
    }
}
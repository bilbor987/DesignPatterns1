namespace Visitor
{
    public class Keyboard : IComputerPart
    {
        private int NumberOfKeys;
        public Keyboard()
        {
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
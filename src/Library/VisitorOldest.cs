using System;
namespace Library
{
    public class VisitorOldest : IVisitor
    {
        public Node Oldest { get; set; }

        public void GetOldest(Node node)
        {
            if (node.Children.Count > 0)
            {
                foreach (Node children in node.Children)
                {
                    if (this.Oldest.Person.Age < children.Person.Age)
                    {
                        this.Oldest = children;
                    }
                    children.Accept(this);
                }
            }
            Console.WriteLine(Oldest.Person.Name);
        }
        public void Visit(Node node)
        {
            this.GetOldest(node);
        }

        public VisitorOldest ()
        {
            this.Oldest = new Node(0,0,"Vacio");
        }
    }
}
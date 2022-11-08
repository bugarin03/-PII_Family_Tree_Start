using System;
namespace Library
{
    public class VisitorAge : IVisitor
    {
        public int Age { get; set;}
        public void AddAges(Node node)
        {
            this.Age += node.Person.Age;

            Console.WriteLine(Age);

            if (node.Children.Count > 0)
            {
                foreach (Node children in node.Children)
                {
                    children.Accept(this);
                }
            }
        }

        public void Visit(Node node)
        {
            this.AddAges(node);
        }
    }
}
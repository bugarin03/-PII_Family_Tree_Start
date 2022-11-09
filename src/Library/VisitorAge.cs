using System;
using System.Collections.Generic;
namespace Library
{
    public class VisitorAge : IVisitor
    {
        private List<int> Visited { get; set; }
        public int Age { get; set; }
        public void AddAges(Node node)
        {
            if (!Visited.Contains(node.Number))
            {
                this.Age += node.Person.Age;
                //Visited.Add(node.Number);
                Console.WriteLine(Age);

                if (node.Children.Count > 0)
                {
                    foreach (Node children in node.Children)
                    {
                        children.Accept(this);
                        Visited.Add(children.Number);
                    }
                }
            }
        }

        public void Visit(Node node)
        {
            this.AddAges(node);
        }

        public VisitorAge()
        {
            this.Visited = new List<int>();
        }
    }
}
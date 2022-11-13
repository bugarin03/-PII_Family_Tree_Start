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
                this.VisitPerson(node.Person);
                Visited.Add(node.Number);
                Console.WriteLine(Age);

                if (node.Children.Count > 0)
                {
                    foreach (Node children in node.Children)
                    {
                        children.Accept(this);
                    }
                }
            }
        }

        public override void VisitNode(Node node)
        {
            this.AddAges(node);
        }

        public override void VisitPerson(Person person)
        {
            person.Accept(this);
            Age += person.Age;
        }

        public VisitorAge()
        {
            this.Visited = new List<int>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Library
{
    public class VisitorOldest : IVisitor
    {
        private List<int> Visited { get; set; }
        public Person Oldest { get; set; }

        public void GetOldest(Node node)
        {
            if (!Visited.Contains(node.Number))
            {
                if (node.Children.Count > 0)
                {
                    foreach (Node children in node.Children)
                    {
                        this.VisitPerson(children.Person);
                        children.Accept(this);
                    }
                }
                Console.WriteLine(Oldest.Name);
            }
        }
        public override void VisitNode(Node node)
        {
            this.GetOldest(node);
        }

        public override void VisitPerson(Person person)
        {
            person.Accept(this);
            if (this.Oldest.Age < person.Age)
            {
                this.Oldest = person;
            }
        }

        public VisitorOldest()
        {
            this.Oldest = new Person(0, "");
            this.Visited = new List<int>();
        }
    }
}
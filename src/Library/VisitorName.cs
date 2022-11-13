using System;
using System.Collections.Generic;

namespace Library
{
    public class VisitorName : IVisitor
    {
        public Person Person {get; set;}
        private List<int> Visited { get; set; }
        string WiningName { get; set; }
        public void LongestName(Node node)
        {
            if (!Visited.Contains(node.Number))
            {
                this.VisitPerson(node.Person);
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
            this.LongestName(node);
        }

        public override void VisitPerson(Person person)
        {
            person.Accept(this);
            if (this.WiningName.Length < person.Name.Length)
                {
                    this.WiningName = person.Name;
                }
                Console.WriteLine(this.WiningName);
        }

        public VisitorName()
        {
            this.WiningName = "";
            this.Visited = new List<int>();
        }
    }
}
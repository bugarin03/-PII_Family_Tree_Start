using System;
using System.Collections.Generic;

namespace Library
{
    public class VisitorName : IVisitor
    {
        private List<int> Visited { get; set; }
        string WiningName { get; set; }
        public void LongestName(Node node)
        {
            if (!Visited.Contains(node.Number))
            {
                if (this.WiningName.Length < node.Person.Name.Length)
                {
                    this.WiningName = node.Person.Name;
                }
                Console.WriteLine(this.WiningName);


                if (node.Children.Count > 0)
                {
                    foreach (Node children in node.Children)
                    {
                        children.Accept(this);
                    }
                }
            }
        }
        public void Visit(Node node)
        {
            this.LongestName(node);
        }

        public VisitorName()
        {
            this.WiningName = "";
            this.Visited = new List<int>();
        }
    }
}
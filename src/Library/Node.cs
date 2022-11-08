using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public Person Person { get; }
        private int number;

        private List<Node> children = new List<Node>();

        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }
        ///Se utiliza el patron creator en este método.
        public Node(int number, int age, string name)
        {
            this.number = number;
            this.Person = new Person(age, name);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept (IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1,67,"Maria Lucilda");
            Node n2 = new Node(2,37,"Ramon");
            Node n3 = new Node(3,35,"Jamon");
            Node n4 = new Node(4,16,"Juan");
            Node n5 = new Node(5,15,"Pedro");
            Node n6 = new Node(6,14,"Jaimito");
            Node n7 = new Node(7,21,"Maria");
            Node n8 = new Node(8,10,"Juana");

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí

            VisitorAge visitor = new VisitorAge();
            VisitorName visitor2 = new VisitorName();
            VisitorOldest visitor3 = new VisitorOldest();

            n1.Accept(visitor);
            n1.Accept(visitor2);
            n1.Accept(visitor3);
        }
    }
}

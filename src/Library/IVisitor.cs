using System.Text;
namespace Library
{
    public abstract class IVisitor
    {
        protected StringBuilder ContentBuilder { get; } = new StringBuilder();

        public string Content
        {
            get
            {
                return this.ContentBuilder.ToString();
            }
        }

        public abstract void VisitNode (Node node);

        public abstract void VisitPerson (Person person);
    }
}
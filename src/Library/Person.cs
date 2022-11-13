namespace Library
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public  Person Accept (IVisitor visitor)
        {
            return this;
        }
        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age; 
        }
    }
}
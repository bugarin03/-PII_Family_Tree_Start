namespace Library
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age; 
        }
    }
}
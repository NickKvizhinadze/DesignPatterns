namespace Factory.Models
{
    public class Person
    {
        private static int LastId = -1;

        public Person(string name)
        {
            Id = ++LastId;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

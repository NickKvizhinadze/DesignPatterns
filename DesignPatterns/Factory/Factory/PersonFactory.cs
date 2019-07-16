using Factory.Models;

namespace Factory
{
    public class PersonFactory
    {
        public Person CreatePerson(string name)
        {
            return new Person(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ChatRoom
{
    public class Room
    {
        private List<Person> people = new List<Person>();

        public void Join(Person p)
        {
            Broadcast("room", $"{p.Name} has joined to the chat");
            people.Add(p);
            p.Room = this;
        }

        public void Broadcast(string source, string message)
        {
            foreach (var person in people)
            {
                if (person.Name != source)
                    person.Receive(source, message);
            }
        }

        public void Message(string source, string destination, string message)
        {
            people.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
        }
        
    }
}

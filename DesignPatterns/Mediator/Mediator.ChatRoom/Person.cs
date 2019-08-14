using System;
using System.Collections.Generic;

namespace Mediator.ChatRoom
{
    public class Person
    {
        public string Name;
        public Room Room;
        public List<string> ChatLogs = new List<string>();

        public Person(string name)
        {
            Name = name;
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }

        public void Receive(string sender, string message)
        {
            var result = $"{sender}: {message}";
            ChatLogs.Add(result);
            Console.WriteLine($"[{Name}'s chat session] {result}");
        }
    }
}

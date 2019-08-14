using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room();
            var john = new Person("John");
            var jane = new Person("Jane");
            var simon = new Person("Simon");

            room.Join(john);
            room.Join(jane);

            john.Say("hi");
            jane.Say("oh, hey john");

            room.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "hi simon");
        }
    }
}

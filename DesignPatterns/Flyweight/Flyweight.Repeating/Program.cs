using Flyweight.Repeating.Models;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Repeating
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void TestUser()
        {
            var firsNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var users = new List<User>();
            foreach (var firstName in firsNames)
            {
                foreach (var lastName in lastNames)
                {
                    users.Add(new User($"{firstName} {lastName}"));
                }
            }

            ForceGc();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        [Test]
        public void TestUser2()
        {
            var firsNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var users = new List<User2>();
            foreach (var firstName in firsNames)
            {
                foreach (var lastName in lastNames)
                {
                    users.Add(new User2($"{firstName} {lastName}"));
                }
            }

            ForceGc();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }


        private void ForceGc()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            Random random = new Random();
            return new string(Enumerable.Range(0, 10).Select(i => (char)('a' + random.Next(26))).ToArray());
        }
    }
}

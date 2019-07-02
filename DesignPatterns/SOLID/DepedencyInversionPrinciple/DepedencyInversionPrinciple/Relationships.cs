using DepedencyInversionPrinciple.Interfaces;
using DepedencyInversionPrinciple.Models;
using System.Collections.Generic;
using System.Linq;

namespace DepedencyInversionPrinciple
{
    public class Relationships : IRelationshipBrowser
    {
        private readonly List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations
                .Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent)
                .Select(x => x.Item3);
        }

        //public List<(Person, Relationship, Person)> Relations => _relations;
    }
}

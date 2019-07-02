using System.Collections.Generic;

namespace OpenClosePrinciple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}

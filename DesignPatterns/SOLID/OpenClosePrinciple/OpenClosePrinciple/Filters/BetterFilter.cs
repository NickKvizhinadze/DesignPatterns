﻿using System.Collections.Generic;
using OpenClosePrinciple.Models;

namespace OpenClosePrinciple.Filters
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var product in items)
            {
                if (spec.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}

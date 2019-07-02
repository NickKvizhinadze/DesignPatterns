﻿using InterfaceSegregationPrinciple.Models;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
    }
}

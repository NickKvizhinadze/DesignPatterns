using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Models
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            //
        }

        public void Scan(Document document)
        {
            //
        }
    }
}

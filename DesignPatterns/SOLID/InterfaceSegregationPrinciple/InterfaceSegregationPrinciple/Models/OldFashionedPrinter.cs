using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models
{
    public class OldFashionedPrinter : IPrinter
    {
        public void Fax(Document document)
        {
            throw new System.NotImplementedException();
        }

        public void Print(Document document)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new System.NotImplementedException();
        }
    }
}

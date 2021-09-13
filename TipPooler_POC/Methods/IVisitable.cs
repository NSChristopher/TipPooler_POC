using System.Collections.Generic;

namespace TipPooler_POC.Methods
{
    internal interface IVisitable
    {
        public void Accept(IVisitor visitor);
    }

    internal interface IVisitor
    {
        public List<T> SupplyData();
    }
}
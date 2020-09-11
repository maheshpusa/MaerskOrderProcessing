using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.BusinessRules;
using System;

namespace OrderProcessor.Helper
{
    public class Class1
    {
        public void processpackage(string prodcutCategory)
        {
            IProcessOrderRule res = (IProcessOrderRule)Activator.CreateInstance("OrderProcessor.BusinessRules", prodcutCategory);
            res.ProcessOrder();

        }
    }
}

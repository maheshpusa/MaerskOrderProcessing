using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules.Abstract
{
    public interface IProcessOrderRule
    {
        void ProcessOrder(Customer customer);
    }
}

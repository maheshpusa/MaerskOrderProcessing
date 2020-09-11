using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class LearningToSkiRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer )
        {
            GeneratePackingSlip(customer);
        }
    }
}

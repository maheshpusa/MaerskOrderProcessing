using OrderProcessor.BusinessRules.Abstract;
using System;

namespace OrderProcessor.BusinessRules
{
    public class BookRule : IProcessOrderRule
    {
        public new void ProcessOrder()
        {
            var physicalProductRule = new PhysicalProductRule();
            //for customer
            physicalProductRule.GeneratePackingSlip();
            //for royalty
            physicalProductRule.GeneratePackingSlip();

            //for agent
            physicalProductRule.GenerateAgentCommission();
        }
    }
}

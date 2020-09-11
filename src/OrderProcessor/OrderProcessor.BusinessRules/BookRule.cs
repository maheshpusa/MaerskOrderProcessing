using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class BookRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder()
        {
            //for customer
            GeneratePackingSlip();

            //for royalty
            GeneratePackingSlip();

            //agent commission
            GenerateAgentCommission();
        }
    }
}

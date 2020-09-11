using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class BookRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer)
        { 
            //for customer
            GeneratePackingSlip(customer);
             
            //for royalty
            GeneratePackingSlip(customer);

            string agentname = "Mahesh";
            //agent commission
            GenerateAgentCommission(agentname);
        }
    }
}

using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class PhysicalProductRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer)
        {
            List<string> productList = new List<string>();
            productList.Add("Book");

            //for customer
            GeneratePackingSlip(customer, productList);

            string agentname = "Mahesh";
            GenerateAgentCommission(agentname);
        }


    }
}

using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class PhysicalProductRule : IProcessOrderRule
    {
        public void ProcessOrder()
        {
            GeneratePackingSlip();
            GenerateAgentCommission();
        }
        public void GeneratePackingSlip()
        {
            //Here comes the logic for packing slip.
            Console.WriteLine("Packing Slip Got Generated");
        }

        public void GenerateAgentCommission()
        {
            //Here comes the logic for calculating agent commission and generate slip.
            Console.WriteLine("Agent commison is");
        }
    }
}
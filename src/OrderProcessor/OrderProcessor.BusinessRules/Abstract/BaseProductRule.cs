using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules.Abstract
{
    public abstract class BaseProductRule : IProcessOrderRule
    {
        public abstract void ProcessOrder();

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

        public void ActivateMembership()
        {
            //Here comes the logic for Activating membership
            Console.WriteLine("Membership got activated");
        }

        public void UpgradeMembership()
        {
            //Here comes the logic for Ugrading membership
            Console.WriteLine("Membership got upgraded");
        }
    }
}

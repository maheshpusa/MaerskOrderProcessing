using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules.Abstract
{
    public abstract class BaseProductRule : IProcessOrderRule
    {
        public abstract void ProcessOrder( Customer customer);

        public void GeneratePackingSlip(Customer customer, List<string> productList)
        {
            //Here comes the logic for packing slip.
            Console.WriteLine("Packing Slip Got Generated");
        }

        public void GenerateAgentCommission(string recipient)
        {
            //Here comes the logic for calculating agent commission and generate slip.
            Console.WriteLine("Agent commison is");
        }

        public void ActivateMembership(Customer customer)
        {
            //Here comes the logic for Activating membership
            Console.WriteLine("Membership got activated");
        }

        public void UpgradeMembership(Customer customer)
        {
            //Here comes the logic for Ugrading membership
            Console.WriteLine("Membership got upgraded");
        }

        public void SendEmail(string mailid, MemberShipType memberShipType)
        {
            string msg =  CreateMembershipMessage(memberShipType.ToString());
            //here comesthe logic for sending email
            Console.WriteLine(msg);
        }

        private string CreateMembershipMessage(string memberShipType)
        {
            //ToDo : redesign this block bases on membership types.
            string msg = "";
            if (memberShipType.ToLower() == "new")
                msg = "Dear Customer,  Your membership got activated valid till ";
            else if (memberShipType.ToLower() == "upgrade")
                msg = "Dear Customer,  Your membership got upgraded to Gold";

            return msg;
        }
    }
}

using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class NewMemberShipRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer, List<string> productList)
        {
            ActivateMembership(customer);

            SendEmail(customer.Email, MemberShipType.New);
        }
    }
}

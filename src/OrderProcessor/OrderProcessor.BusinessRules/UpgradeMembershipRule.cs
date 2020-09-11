using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;
using System.Collections.Generic;

namespace OrderProcessor.BusinessRules
{
    public class UpgradeMembershipRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer, List<string> productList)
        {
            UpgradeMembership(customer);

            SendEmail(customer.Email, MemberShipType.Upgrade);
        }
    }
}

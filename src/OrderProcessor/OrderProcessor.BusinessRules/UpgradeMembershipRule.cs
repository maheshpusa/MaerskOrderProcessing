using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.Domain;

namespace OrderProcessor.BusinessRules
{
    public class UpgradeMembershipRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder(Customer customer)
        {
            UpgradeMembership(customer);
        }
    }
}

using OrderProcessor.BusinessRules.Abstract;

namespace OrderProcessor.BusinessRules
{
    class UpgradeMembershipRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder()
        {
            UpgradeMembership();
        }
    }
}

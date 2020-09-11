using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class UpgradeMembershipRule : IProcessOrderRule
    {
        public void ProcessOrder()
        {
            UpgradeMembership();
        }

        private void UpgradeMembership()
        {

        }
    }
}

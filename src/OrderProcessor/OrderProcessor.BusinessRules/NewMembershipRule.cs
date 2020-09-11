using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    public class NewMemberShipRule : IProcessOrderRule
    {
        public void ProcessOrder()
        {
            ActivateMembership();
        }

        private void ActivateMembership()
        {

        }
    }
}

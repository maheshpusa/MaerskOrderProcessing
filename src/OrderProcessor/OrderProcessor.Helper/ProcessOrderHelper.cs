using OrderProcessor.BusinessRules.Abstract;
using OrderProcessor.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using OrderProcessor.Domain;

namespace OrderProcessor.Helper
{
    public class ProcessOrderHelper
    {
        List<IProcessOrderRule> _rules = new List<IProcessOrderRule>();
        public ProcessOrderHelper()
        {
            // need to add all new rules or product categories
            _rules.Add(new BookRule());
            _rules.Add(new LearningToSkiRule());
            _rules.Add(new NewMemberShipRule());
            _rules.Add(new PhysicalProductRule());
            _rules.Add(new UpgradeMembershipRule()); 
        }

        public void processpackage(string prodcutCategory, Customer customer)
        {
            prodcutCategory = "OrderProcessor.BusinessRules." + prodcutCategory;
            //IProcessOrderRule res = (IProcessOrderRule)Activator.CreateInstance("OrderProcessor.BusinessRules", "OrderProcessor.BusinessRules." + prodcutCategory);
            var rule = _rules.FirstOrDefault(e => e.ToString() == prodcutCategory);

            
            rule.ProcessOrder(customer);

        }
    }
}

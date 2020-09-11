using OrderProcessor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules.Abstract
{
    public interface IProcessOrderRule
    {
        //product list is provided in case of multiple items tobe included in the packing list
        void ProcessOrder(Customer customer,List<string> productList);

    }
}

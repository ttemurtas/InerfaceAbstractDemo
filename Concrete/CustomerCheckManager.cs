using InerfaceAbstractDemo.Abstract;
using InerfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using InerfaceAbstractDemo.Abstract;

namespace InerfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

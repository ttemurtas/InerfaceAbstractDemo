using InerfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InerfaceAbstractDemo
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

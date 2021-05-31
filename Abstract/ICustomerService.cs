using InerfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InerfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}

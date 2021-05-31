using InerfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InerfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to DB: " + customer.FirstName);
        }
    }
}

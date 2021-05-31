using InerfaceAbstractDemo.Abstract;
using InerfaceAbstractDemo.Adapters;
using InerfaceAbstractDemo.Concrete;
using InerfaceAbstractDemo.Entities;
using System;

namespace InerfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995, 10, 17), FirstName = "Tayfun", LastName = "Temurtaş", NationalityId = "21722405812" });
        }
    }
}

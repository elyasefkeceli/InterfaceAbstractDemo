using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;
using System;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new System.DateTime(1996, 2, 2), FirstName = "Elyase Faruk",LastName="Keçeli",NationalityId="67837025682" });

            Console.ReadLine();
            
        }
    }
}

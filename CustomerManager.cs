using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.firstName +" is added!");
        }

        public void Upgrade(Customer customer)
        {
            Console.WriteLine(customer.firstName +" is upgrade her/his details!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.firstName +" is deleted!");
        }
           
    }
}

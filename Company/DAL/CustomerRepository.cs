using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDBEntities context;

        public CustomerRepository(SampleDBEntities context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Customer GetCustomerByID(int id)
        {
            return context.Customers.Find(id);
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}
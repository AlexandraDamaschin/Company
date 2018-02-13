using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DAL
{
    public class ICustomerRepository : IDisposable
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByID(int id);
    }
}
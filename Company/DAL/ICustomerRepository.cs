using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL
{
    public interface ICustomerRepository : IDisposable
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByID(int id);
    }
}

using BaiTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string Id);
        bool EditCustomer(Customer customer);
        Guid AddCustomer(Customer customer);
        bool DeleteCustomer(string id);
    }
}

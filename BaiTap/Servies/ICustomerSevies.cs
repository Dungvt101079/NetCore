using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap.Models;
namespace BaiTap.Servies
{
    public interface ICustomerSevies
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string Id);
        bool EditCustomer(Customer customer);
        Guid AddCustomer(Customer customer);
        bool DeleteCustomer(string id);
    }
}

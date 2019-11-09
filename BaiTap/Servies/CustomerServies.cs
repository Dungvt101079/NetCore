using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap.Models;
using BaiTap.Repositories;
namespace BaiTap.Servies
{
    public class CustomerServies : ICustomerSevies
    {
        private readonly ICustomerRepository _repo;
        public CustomerServies(ICustomerRepository repo)
        {
            _repo = repo;
        }
        bool ICustomerSevies.AddCustomer(Customer customer)
        {
            return _repo.AddCustomer(customer);
        }

        bool ICustomerSevies.DeleteCustomer(string id)
        {
            return _repo.DeleteCustomer(id);
        }

        bool ICustomerSevies.EditCustomer(Customer customer)
        {
            return _repo.EditCustomer(customer);
        }

        Customer ICustomerSevies.GetCustomerById(string Id)
        {
            return _repo.GetCustomerById(Id);
        }

        List<Customer> ICustomerSevies.GetCustomers()

        {
            return _repo.GetCustomers();
        }
    }
}

using BaiTap.Data;
using BaiTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                using (_context)
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool DeleteCustomer(string id)
        {
            try
            {
                using (_context)
                {
                    _context.Customers.Remove(_context.Customers.FirstOrDefault(c=>c.Id == new Guid(id)));
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            try
            {
                using (_context)
                {
                    var customerEntity = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);

                    customerEntity.Name = customer.Name;
                    customerEntity.Age = customer.Age;
                    customerEntity.Address = customer.Address;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Customer GetCustomerById(string id)
        {
            try
            {
                using (_context)
                {
                    var listCustomer = _context.Customers.FirstOrDefault(x => x.Id == new Guid(id));
                    return listCustomer;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                using (_context)
                {
                    var listCustomer = _context.Customers.ToList();
                    return listCustomer;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}

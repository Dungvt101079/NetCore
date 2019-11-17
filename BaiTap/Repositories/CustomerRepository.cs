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

        public Guid AddCustomer(Customer customer)
        {
            try
            {

                _context.Customers.Add(customer);
                _context.SaveChanges();
                return customer.Id;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Guid.Empty;
            }

        }

        public bool DeleteCustomer(string id)
        {
            try
            {

                _context.Customers.Remove(_context.Customers.FirstOrDefault(c => c.Id == new Guid(id)));
                _context.SaveChanges();
                return true;

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

                var customerEntity = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);

                customerEntity.Name = customer.Name;
                customerEntity.Age = customer.Age;
                customerEntity.Address = customer.Address;
                customerEntity.UpdatedBy = customer.Id.ToString();
                customerEntity.UpdatedDate = DateTime.Now;
                _context.SaveChanges();
                return true;

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

                var listCustomer = _context.Customers.FirstOrDefault(x => x.Id == new Guid(id));
                return listCustomer;

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

                var listCustomer = _context.Customers.ToList();
                return listCustomer;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}

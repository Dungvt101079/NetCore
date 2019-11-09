using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap.Models;
namespace BaiTap.Sevies
{
    public class CustomerServies
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Customer> GetCustomers()
        {
            return customers;
        }
        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);

        }
        public static void EditbyID(Customer customer)
        {
            foreach (var item in customers)
            {
                if (item.ID == customer.ID)
                {
                    item.Name = customer.Name;
                    item.Age = customer.Age;
                    
                }
            }
        }
        public static Customer GetCustomersbyID(int ID)
        {

            return customers.FirstOrDefault(c => c.ID == ID);
        }
        public static void DeleteCustomersbyID(int ID)
        {

            customers.Remove(customers.FirstOrDefault(c => c.ID == ID));

        }
    }
}

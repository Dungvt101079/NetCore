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
            
        }
        public static Customer GetCustomersbyID(int ID)
        {

            return null;
        }
        public static void DeleteCustomersbyID(int ID)
        {

            

        }
    }
}

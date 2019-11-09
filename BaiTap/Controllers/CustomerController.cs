using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaiTap.Models;
using BaiTap.Sevies;
namespace BaiTap.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var lisCustomer = new List<Customer>();
            lisCustomer = CustomerServies.GetCustomers();

            //lisCustomer.Add(new Customer
            //{ Age = 31, Name = "BachNX", ID = 1 });
            //lisCustomer.Add(new Customer
            //{ Age = 6, Name = "MaiVC", ID = 2 });
            //lisCustomer.Add(new Customer
            //{ Age = 4, Name = "KienVM", ID = 3 });
            //lisCustomer.Add(new Customer
            //{ Age = 41, Name = "DungVT", ID = 4 });
            var selectLisCustomer = new List<Customer>();
            //foreach (var cutomer in lisCustomer)
            //{
            //    if (cutomer.Age > 30) { selectLisCustomer.Add(cutomer); }

            //}
            return View(lisCustomer);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save(Customer customer)
        {
            CustomerServies.AddCustomer(customer);
            return Redirect("Index");
        }
        public IActionResult EditbyID(Customer customer)
        {
            CustomerServies.EditbyID(customer);
            return Redirect("Index");
        }
        public IActionResult Edit(Int32 id)
        {
            Customer customer = CustomerServies.GetCustomersbyID(id);
            return View(customer);
        }
        public IActionResult View(Int32 id)
        {
            Customer customer = CustomerServies.GetCustomersbyID(id);
            return View(customer);
        }
        public IActionResult Delete(Int32 id)
        {
            CustomerServies.DeleteCustomersbyID(id);
            return RedirectToAction("Index");
        }
    }

}
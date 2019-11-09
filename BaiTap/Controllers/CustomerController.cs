using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaiTap.Models;
using BaiTap.Servies;

namespace BaiTap.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerSevies _service;
        public CustomerController(ICustomerSevies service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var lisCustomer = _service.GetCustomers();

            return View(lisCustomer);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save(Customer customer)
        {
            _service.AddCustomer(customer);
            
            return Redirect("Index");
        }
        public IActionResult EditbyID(Customer customer)
        {
            _service.EditCustomer(customer);
            return Redirect("Index");
        }
        public IActionResult Edit(string id)
        {
            Customer customer = _service.GetCustomerById(id);
            return View(customer);
        }
        public IActionResult View(string id)
        {
            Customer customer = _service.GetCustomerById(id);
            return View(customer);
        }
        public IActionResult Delete(string id)
        {
            _service.DeleteCustomer(id);
            return RedirectToAction("Index");
        }

       
    }

}
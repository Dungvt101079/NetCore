using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap.Servies;
using BaiTap.ViewModels;
using BaiTap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaiTap.Controllers
{
    public class TeaController : Controller
    {
        private readonly ICustomerSevies _service;
        private readonly ITeaOrderService _orderService;
        public TeaController(ICustomerSevies service, ITeaOrderService orderService)
        {
            _service = service;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var a = _orderService.GetOrders();
            return View(a);
        }

        public IActionResult OrdersByCustomer(Guid Id)
        {
            var a = _orderService.GetOrderById(Id);
            return View(a);
        }

        public IActionResult Create()
        {
            TeaOrderViewModel model = new TeaOrderViewModel();
            model.CustomerSelections = _service.GetCustomers().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            model.Teas = _orderService.GetTeas().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();

            return View(model);
        }

        public IActionResult SaveCreate(TeaOrderViewModel model)
        {
            _orderService.AddOrder(model);
            return Redirect("Index");
        }
        public IActionResult View(string id)
        {
            return View();
        }
        public IActionResult Edit(Guid id)
        {
            TeaOrderViewModel teaOrder = _orderService.GetOrderById(id);
            teaOrder.CustomerSelections = _service.GetCustomers().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            teaOrder.Teas = _orderService.GetTeas().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            return View(teaOrder);
        }
        public IActionResult Delete(string id)
        {
            return View();
        }
        public IActionResult SaveEdit(TeaOrderViewModel model)
        {
            _orderService.EditOrder(model);
            return Redirect("Index");
        }
    }
}

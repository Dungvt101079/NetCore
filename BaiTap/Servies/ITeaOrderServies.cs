using BaiTap.Models;
using BaiTap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Servies
{
    public interface ITeaOrderService
    {
        List<TeaOrderViewModel> GetOrders();
        TeaOrderViewModel GetOrderById(Guid Id);
        bool EditOrder(TeaOrderViewModel teaOrder);
        bool AddOrder(TeaOrderViewModel teaOrderViewModel);
        bool DeleteOrder(string id);
        List<Tea> GetTeas();
    }
}

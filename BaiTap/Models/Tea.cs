
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaiTap.Models
{
    public class Tea:BaseModel
    {
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Giá tiền")]
        public Int32 Price { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        public IList<TeaOrderTea> TeaOrderTeas { get; set; }
    }
}

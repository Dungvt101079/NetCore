using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BaiTap.Models
{
    public class Customer :BaseModel
    {
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Tuổi")]
        public Int32 Age { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
    }
}

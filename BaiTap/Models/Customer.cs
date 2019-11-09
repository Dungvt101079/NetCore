using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BaiTap.Models
{
    public class Customer
    {
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Tuổi")]
        public Int32 Age { get; set; }
        public Int32 ID { get; set; }

    }
}

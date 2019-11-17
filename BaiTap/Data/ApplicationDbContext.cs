using System;
using System.Collections.Generic;
using System.Text;
using BaiTap.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaiTap.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Tea> Teas { get; set; }
        public DbSet<TeaOrder> TeaOrders { get; set; }
        public DbSet<TeaOrderTea> TeaOrderTeas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

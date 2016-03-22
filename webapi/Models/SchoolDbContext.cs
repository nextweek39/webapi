using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using webapi.Entities;

namespace webapi.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            : base("name=DefaultConnection")
        {

        }

        //public DbSet<Student> Student { get; set; }
        //public DbSet<StudentAddress> StudentAddress { get; set; }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }

    }
}
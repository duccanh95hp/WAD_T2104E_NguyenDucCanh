using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenDucCanh.Models
{
    public class DbContexta : DbContext
    {
        public DbContexta() : base("name:contest")
        {

        }
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
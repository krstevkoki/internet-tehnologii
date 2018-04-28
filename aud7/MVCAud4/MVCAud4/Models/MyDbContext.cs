using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAud4.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Client> Clients { get; set; }

        public MyDbContext() : base("MineConnection")
        {
        }

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }
    }
}
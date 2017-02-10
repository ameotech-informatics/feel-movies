using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieFeeler.DAO
{
    public class MFContext : DbContext
    {
        public MFContext() :
            base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Movies> Movies { get; set; }

    }
}
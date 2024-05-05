using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ObligatoriskOpgave2.Models;

namespace ObligatoriskOpgave2.DAL
{
    public class WebShopContext : DbContext
    {

        public WebShopContext() : base("WebShopContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<ObligatoriskOpgave2.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<ObligatoriskOpgave2.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<ObligatoriskOpgave2.Models.Music> Musics { get; set; }
    }
}
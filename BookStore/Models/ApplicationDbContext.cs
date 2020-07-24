using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OnlineBookStore;Integrated Security=True");
        }
    }
}

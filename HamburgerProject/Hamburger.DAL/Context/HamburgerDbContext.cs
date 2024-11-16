using Hamburger.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Context
{
    public class HamburgerDbContext : DbContext
    {
        private static string _connectionString;

        public HamburgerDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Conn");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<ExtraFood> ExtraFoods
        {
            get; set;
        }
        public DbSet<Menu> Menus
        {
            get; set;
        }
        public DbSet<Order> Orders
        {
            get; set;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using DAL.Model;

namespace DAL
{
    public class MainDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString2"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'ConnectionString' is missing or empty. Check App.config!");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

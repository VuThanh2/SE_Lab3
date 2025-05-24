using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Reflection.Emit;

namespace DAL
{
    public class MainDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LabDBConnectionString"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'SchoolDBConnectionString' is missing or empty. Check App.config!");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserID); // Define UserId as the primary key
            modelBuilder.Entity<Customer>()
                .HasKey(u => u.Id); // Define Id as the primary key
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Model;
using System.Data.SqlClient;

//namespace DAL
//{
//    public class ManagerDbContext : DbContext
//    {
//        public ManagerDbContext() : base("name=Lab02ConnectionString2")
//        {
//            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
//            Database.SetInitializer<ManagerDbContext>(null);
//        }
//        public DbSet<User> Users { get; set; }
//        public DbSet<Customer> Customers { get; set; }
//    }
//}

//namespace DAL.Model
//{
//    public class ManagerDbContext : DbContext
//    {
//        public ManagerDbContext() : base("Lab02ConnectionString") // Ensure this matches your App.config
//        {
//        }

//        public DbSet<Customer> Customers { get; set; }
//    }
//}

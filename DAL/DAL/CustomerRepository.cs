using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Model;

namespace DAL
{
    public class CustomerRepository
    {
        private readonly string connectionString;

        // Constructor - Read connection string from App.config
        public CustomerRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Lab02ConnectionString"].ConnectionString;
        }
        // Get all customers using ADO.NET
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return customers;
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using DAL.Model;
//using DAL;

//namespace DAL
//{
//    public class CustomerRepository
//    {
//        private readonly ManagerDbContext _context;

//        // Constructor - Initialize DbContext
//        public CustomerRepository()
//        {
//            _context = new ManagerDbContext();
//        }

//        // Get all customers using Entity Framework
//        public List<Customer> GetAllCustomers()
//        {
//            return _context.Customers.ToList();
//        }
//    }
//}

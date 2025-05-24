using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Model;

namespace DAL
{
    public class UserRepository
    {
        private readonly string connectionString;

        // Constructor - Read connection string from App.config
        public UserRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Lab02ConnectionString"].ConnectionString;
        }

        // Get all users using ADO.NET
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return users;
        }
    }
}

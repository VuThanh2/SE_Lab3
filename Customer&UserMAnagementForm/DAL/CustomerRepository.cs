using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class CustomerRepository
    {
        private readonly MainDbContext _mainDbContext;
        public CustomerRepository() 
        {
            _mainDbContext = new MainDbContext();
        }
        public List<Customer> GetAllCustomers()
        {
            return _mainDbContext.Customers.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            _mainDbContext.Customers.Add(customer);
            _mainDbContext.SaveChanges();
        }
    }
}

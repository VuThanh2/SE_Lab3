using DAL;
using Microsoft.EntityFrameworkCore;

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
        public Customer GetCustomerById(int id)
        {
            return _mainDbContext.Customers.FirstOrDefault(x => x.Id == id);
        }
        public Customer AddCustomer(Customer customer)
        {
            _mainDbContext.Customers.Add(customer);
            _mainDbContext.SaveChanges();
            return customer;
        }
    }
}

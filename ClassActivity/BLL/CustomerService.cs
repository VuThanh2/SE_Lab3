using Microsoft.EntityFrameworkCore;
using DAL;

namespace BLL
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }
        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
        public Customer GetCustomerById(int id) 
        {
            return _customerRepository.GetCustomerById(id);
        }
        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}

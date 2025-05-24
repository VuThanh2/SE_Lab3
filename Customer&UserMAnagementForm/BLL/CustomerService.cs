using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;

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
        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Business.Repositories;
using Interview.Model.Types;

namespace Interview.Business.Services
{
    /// <summary>
    /// Manages customers.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        /// <summary>
        /// Retrieves a single customer with the provided customer id.
        /// </summary>
        /// <param name="id">Customer unique identifier.</param>
        /// <returns>Single customer object.</returns>
        public async Task<Customer> GetCustomer(string id)
        {
            return await _customerRepository.GetCustomer(id);
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        /// <summary>
        /// Retrieves customers with the provided filter.
        /// </summary>
        /// <param name="filter">Filter to apply.</param>
        /// <returns>Results of customer filter.</returns>
        public List<Customer> GetCustomers(Func<Customer, bool> filter)
        {
            return _customerRepository.GetCustomers().Where(filter).ToList();
        }

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">New customer to add.</param>
        /// <returns>Added customer.</returns>
        public Customer AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }
    }
}

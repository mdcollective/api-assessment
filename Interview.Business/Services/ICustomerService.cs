using System.Collections.Generic;
using Interview.Model.Types;

namespace Interview.Business.Services
{
    /// <summary>
    /// Manages customers.
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Retrieves a single customer with the provided customer id.
        /// </summary>
        /// <param name="id">Customer unique identifier.</param>
        /// <returns>Single customer object.</returns>
        public Customer GetCustomer(string id);

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        public List<Customer> GetCustomers();

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">New customer to add.</param>
        /// <returns>Added customer.</returns>
        public Customer AddCustomer(Customer customer);
    }
}

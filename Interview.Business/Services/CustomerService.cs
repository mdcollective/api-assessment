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
        public Customer GetCustomer(string id)
        {
            return _customerRepository.GetCustomer(id);
        }
    }
}

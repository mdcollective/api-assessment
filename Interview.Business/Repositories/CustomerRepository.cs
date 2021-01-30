using System.Collections.Generic;
using Interview.Model.Types;

namespace Interview.Business.Repositories
{
    /// <summary>
    /// Manages customers.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Retrieves a single customer with the provided customer id.
        /// </summary>
        /// <param name="id">Customer unique identifier.</param>
        /// <returns>Single customer object.</returns>
        public Customer GetCustomer(string id)
        {
            return new Customer
            {
                Id = "1",
                FirstName = "John",
                LastName = "Doe",
                Age = 19,
                Gender = "male"
            };
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = "1",
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 19,
                    Gender = "male"
                },
                new Customer
                {
                    Id = "2",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 18,
                    Gender = "female"
                }
            };
        }
    }
}

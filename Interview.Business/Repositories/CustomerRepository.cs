﻿using System.Collections.Generic;
using System.Linq;
using Interview.Model.Types;

namespace Interview.Business.Repositories
{
    /// <summary>
    /// Manages customers.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Mock customers.
        /// </summary>
        private readonly List<Customer> _customers = new List<Customer>
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

        /// <summary>
        /// Retrieves a single customer with the provided customer id.
        /// </summary>
        /// <param name="id">Customer unique identifier.</param>
        /// <returns>Single customer object.</returns>
        public Customer GetCustomer(string id)
        {
            return _customers.FirstOrDefault(_ => _.Id == id);
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}

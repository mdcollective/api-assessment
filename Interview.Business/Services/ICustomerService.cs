﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        Task<Customer> GetCustomer(string id);

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Retrieves customers with the provided filter.
        /// </summary>
        /// <param name="filter">Filter to apply.</param>
        /// <returns>Results of customer filter.</returns>
        List<Customer> GetCustomers(Func<Customer, bool> filter);

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">New customer to add.</param>
        /// <returns>Added customer.</returns>
        Customer AddCustomer(Customer customer);
    }
}

using System.Collections.Generic;
using System.Linq;
using Interview.Dtos;
using Interview.Model.Types;

namespace Interview.Extensions
{
    /// <summary>
    /// Extension methods for the Customer class.
    /// </summary>
    public static class CustomerExtensions
    {
        /// <summary>
        /// Maps a customer object to a customer dto object.
        /// </summary>
        /// <param name="customer">Customer object.</param>
        /// <returns>Customer dto object.</returns>
        public static CustomerDto ToCustomerDto(this Customer customer)
        {
            if (customer == null)
                return default;

            return new CustomerDto
            {
                Id = customer.Id,
                Age = customer.Age,
                Gender = customer.Gender,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                FullName = $"{customer.FirstName} {customer.LastName}"
            };
        }

        /// <summary>
        /// Maps a list of customers to a list of customer dtos.
        /// </summary>
        /// <param name="customers">List of customers.</param>
        /// <returns>List of customer dtos.</returns>
        public static List<CustomerDto> ToCustomersDto(this List<Customer> customers)
        {
            if (customers == null)
                return default;

            return customers.Select(ToCustomerDto).ToList();
        }
        
    }
}

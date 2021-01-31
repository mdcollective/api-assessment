﻿namespace Interview.Model.Types
{
    /// <summary>
    /// Customer domain object.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Age of customer.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Unique identifier of customer.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// First name of customer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of customer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gender of customer.
        /// </summary>
        public string Gender { get; set; }
    }
}

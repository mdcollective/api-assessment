using Interview.Business.Services;
using Moq;
using NUnit.Framework;

namespace Interview.Business.Tests
{
    [TestFixture, Category("Unit")]
    public class CustomerServiceTests
    {
        private CustomerService _customerService;

        [SetUp]
        public void Initialize()
        {
            _customerService = new CustomerService();
        }

        [Test]
        public void GetCustomers_WithCustomerId_ReturnsCustomer()
        {
            Assert.Pass();
        }
    }
}

using Interview.Business.Repositories;
using Interview.Business.Services;
using Interview.Model.Types;
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
            var mockCustomerRepository = new Mock<ICustomerRepository>();

            mockCustomerRepository.Setup(_ => _.GetCustomer(It.IsAny<string>())).Returns(new Customer
            {
                Age = 30,
                FirstName = "John",
                Gender = "M",
                Id = "1",
                LastName = "Doe"
            });

            _customerService = new CustomerService(mockCustomerRepository.Object);
        }

        [Test]
        public void GetCustomer_WithCustomerId_ReturnsCustomer()
        {
            // Arrange
            var id = "1";

            // Act
            var customer = _customerService.GetCustomer(id);

            // Assert
            Assert.IsNotNull(customer);
            Assert.IsInstanceOf<Customer>(customer);
        }

        [Test]
        public void GetCustomers_WithNoParams_ReturnsCustomers()
        {
            // Arrange
            // Act
            var customers = _customerService.GetCustomers();

            // Assert
            Assert.IsNotNull(customers);
            Assert.IsTrue(customers.Count > 1);
        }
    }
}

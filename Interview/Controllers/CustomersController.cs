using Microsoft.AspNetCore.Mvc;
using Interview.Business.Services;

namespace Interview.Controllers
{
    /// <summary>
    /// Manages customers.
    /// </summary>
    [Route("api")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService) => _customerService = customerService;

        /// <summary>
        /// Retrieves a single customer with the provided customer id.
        /// </summary>
        /// <param name="id">Customer unique identifier.</param>
        /// <returns>Single customer object.</returns>
        [HttpGet("customers/{id}")]
        public IActionResult Get(string id)
        {
            var customer = _customerService.GetCustomer(id);

            if (customer != null)
                return Ok(_customerService.GetCustomer(id));
            else
                return NotFound();
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        [HttpGet("customers")]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Interview.Business.Services;
using Microsoft.AspNetCore.Http;
using Interview.Model.Types;

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
            try
            {
                var customer = _customerService.GetCustomer(id);

                if (customer != null)
                    return Ok(_customerService.GetCustomer(id));
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers.</returns>
        [HttpGet("customers")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_customerService.GetCustomers());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">New customer to add.</param>
        /// <returns>Added customer.</returns>
        [HttpPost("customers")]
        public IActionResult Post(Customer customer)
        {
            try
            {
                var isDuplicateCustomer = _customerService.GetCustomers(_ =>
                    _.FirstName.ToLower() == customer.FirstName.ToLower() &&
                    _.LastName.ToLower() == customer.LastName.ToLower());

                if (isDuplicateCustomer.Count > 0)
                    return StatusCode(StatusCodes.Status400BadRequest);

                var addCustomer = _customerService.AddCustomer(customer);

                if (customer != null)
                    return StatusCode(StatusCodes.Status201Created);
                else
                    return StatusCode(StatusCodes.Status400BadRequest);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

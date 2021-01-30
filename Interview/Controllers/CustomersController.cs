using Microsoft.AspNetCore.Mvc;
using Interview.Model.Types;
using Microsoft.AspNetCore.Http;
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
            return Ok(_customerService.GetCustomer(id));
        }

        // public IActionResult Get()
        // {
        //     return null;
        // }
    }
}

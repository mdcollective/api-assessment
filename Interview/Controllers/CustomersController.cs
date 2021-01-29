using Microsoft.AspNetCore.Mvc;
using Interview.Model.Types;
using Microsoft.AspNetCore.Http;

namespace Interview.Controllers
{
    [Route("api")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Swashbuckle.AspNetCore.Annotations.SwaggerResponse(StatusCodes.Status200OK, "the Customer", typeof(Customer))]
        public IActionResult Get(string id)
        {
            return null;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return null;
        }
    }
}

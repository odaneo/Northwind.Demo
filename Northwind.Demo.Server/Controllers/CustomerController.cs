using Microsoft.AspNetCore.Mvc;
using Northwind.Demo.Business.IServices;

namespace Northwind.Demo.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomersService _customersService;
        public CustomerController(ICustomersService customersService)
        {
            _customersService = customersService;
        }
        [HttpGet("GetCustomerLondon")]
        public async Task<IActionResult> GetCustomerLondon()
        {
            var list = await _customersService.GetCustomersFromLondon();
            return Ok(list);
        }
    }
}

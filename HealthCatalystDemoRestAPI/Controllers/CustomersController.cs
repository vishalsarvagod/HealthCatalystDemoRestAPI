using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCatalystDemoRestAPI.CustomersData;
using HealthCatalystDemoRestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthCatalystDemoRestAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomersData _customersData;
        public CustomersController(ICustomersData customerData)
        {
            _customersData = customerData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(_customersData.GetCustomers());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCustomer(Guid id)
        {
            var customer = _customersData.GetCustomer(id);
            if(customer != null)
            {
                return Ok(_customersData.GetCustomer(id));
            }

            return NotFound($"Customer with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Getcustomer(Customer customer)
        {
            _customersData.AddCustomer(customer);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + customer.Id,customer);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteCustomer(Guid id)
        {
            var customer = _customersData.GetCustomer(id);
            if(customer != null)
            {
                _customersData.DeleteCustomer(customer);
                return Ok();
            }
            return NotFound($"Customer with Id: {id} was not found");
        }
    }
}

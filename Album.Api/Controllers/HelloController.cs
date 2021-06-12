using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Album_Api.Controllers.Dto;
using Album_Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Album_Api.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        private GreetingService greetingService = new GreetingService();

        [HttpGet]
        public IActionResult Get([FromQuery] string name)
        {
            string greet = greetingService.Greet(name);
            GreetDto response = new GreetDto(){Greet = greet};
            return Ok(response);
        }

    }
}
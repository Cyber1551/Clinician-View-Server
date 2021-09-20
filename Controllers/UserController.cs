using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinician_View_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clinician_View_Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCredentials userCred)
        {
            return Ok();
        }
    }
}

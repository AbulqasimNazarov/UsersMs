using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UsersMs.Controllers
{
    [Route("[controller]")]
    public class Users : Controller
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(UsersMs.Services.UserService.Users);
        }
    }
}
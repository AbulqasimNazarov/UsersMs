using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UsersMs.Models
{
    public class User : IdentityUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
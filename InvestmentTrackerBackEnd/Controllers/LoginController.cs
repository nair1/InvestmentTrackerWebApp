using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentTrackerBackEnd
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            return Ok($"Hello {userLogin.Username}:{userLogin.Password}");
        }

        [HttpPost]
        [Route("Signup")]
        public IActionResult Signup([FromBody] UserSignup userSignup)
        {
            //Check username validity
            //Make a request to DB to get count
            //If count == 0, sign up user
            //Else, return error, username is taken

            if (userSignup.IsValidUsername())
            {
                return Ok($"Hello {userSignup.Username}:{userSignup.Password}");
            } else
            {
                return Ok($"Error: Username '{userSignup.Username}' is already taken!");
            }

            
        }
    }


}

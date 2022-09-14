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
            bool isValidUsername = UserLogin.IsUsernameTaken(userLogin.Username);

            if (!isValidUsername)
            {
                return Unauthorized("Error: username does not exist!");
            }

            bool isValidLogin = userLogin.Login();

            if (!isValidLogin)
            {
                return Unauthorized("Error: Incorrect password!");
            }

            return Ok();
        }

        [HttpPost]
        [Route("Signup")]
        public IActionResult Signup([FromBody] UserSignup userSignup)
        {
            bool isUsernameTaken = UserLogin.IsUsernameTaken(userSignup.Username);

            if (isUsernameTaken)
            {
                return Forbid("Error: Username is already taken!");
            }

            userSignup.Signup();

            return Ok();
        }
    }
}

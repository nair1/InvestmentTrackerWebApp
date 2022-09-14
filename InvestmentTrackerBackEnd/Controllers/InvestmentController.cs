using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentTrackerBackEnd
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentController : Controller
    {
        [HttpPost]
        [Route("GetInvestments")]
        public IActionResult GetInvestments([FromBody] string username)
        {
            List<UserInvestmentDTO> investments = UserInvestment.GetInvestments(username);

            return Ok(investments);
        }
    }
}

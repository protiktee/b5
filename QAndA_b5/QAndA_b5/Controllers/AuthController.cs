using Microsoft.AspNetCore.Mvc;
using QAndA_b5.Model;
using System.ComponentModel.DataAnnotations;

namespace QAndA_b5.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpGet("GetToken/{ValidKey}")]
        public IActionResult GetToken(string ValidKey)
        {
            if (ValidKey == "Protik")
                return Ok(ServiceToken.GenerateServiceToken());
            else
                return Unauthorized();
        }
    }
}

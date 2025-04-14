using Microsoft.AspNetCore.Mvc;

namespace QAndA_b5.Controllers
{
    [Route("[controller]")]
    public class QuestionsController : Controller
    {
        [HttpGet(Name = "QuestionsList")]
        public IActionResult QuestionsList()
        {
            var data = new { 
                Name="Protik",
                Education=""
            };
            return Ok(data);
        }
    }
}

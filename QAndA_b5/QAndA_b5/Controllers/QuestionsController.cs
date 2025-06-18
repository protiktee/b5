using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QAndA_b5.Model;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace QAndA_b5.Controllers
{
    [Route("api/[controller]")] 
    public class QuestionsController : Controller
    {
        [HttpGet("GetData")]
        [Authorize]
        public IActionResult GetData()
        {
            DBConnection dBConnection = new DBConnection();
            DataTable dt=dBConnection.GetData();

            var lData = (from q in dt.AsEnumerable()
                         select new
                         {
                             EquipmentId  = q.Field<Int32>("EquipmentId"),
                             EquipmentName = q.Field<String>("EquipmentName")

                         }).ToList();

            return Ok(lData);
        }
        [HttpGet("QuestionsList")] 
        public IActionResult QuestionsList()
        {
            var data = new { 
                Name="Protik",
                Education=""
            };
            List<string> strings = new List<string>();
            strings.Add("A");
            strings.Add("B");
            return Ok(strings);
        }
        [HttpGet("GetName")] 
        public IActionResult GetName()
        {
            var data = new
            {
                Name = "Protik",
                Education = ""
            };
            return Ok(data);
        }
        [HttpPost("SaveQuestions/{Name}/{age}")]
        public IActionResult SaveQuestions(string Name,string age) 
        {
            return Ok("Save Successfully");
        }
        [HttpPost("SaveQuestionsAnother")]
        public IActionResult SaveQuestionsAnother(string Name)
        {
            return Ok("Save Successfully");
        }
        [HttpPost("SaveAnswer")]
        public IActionResult SaveAnswer([FromBody] clsTest clsTest)
        {
            return Ok(clsTest);
        }
    }
}

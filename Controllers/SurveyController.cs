using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("survey")]
        public IActionResult Results(string Name, string Location, string Language, string Comment)
        {
            Survey newEntry = new Survey()
            {
                Name = Name,
                Location = Location,
                Language = Language,
                Comment = Comment
            };
            return View(newEntry);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(string Name, string Location, string Language, string Comment)
        {
            if (ModelState.IsValid)
            {
                Survey newEntry = new Survey()
                {
                    Name = Name,
                    Location = Location,
                    Language = Language,
                    Comment = Comment
                };

                return View("Results", newEntry);
            }
            else
            {
                return View("index");
            }
        }
    }
}
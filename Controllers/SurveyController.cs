using Microsoft.AspNetCore.Mvc;
namespace dojo_survey
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
            ViewBag.name = Name;
            ViewBag.location = Location;
            ViewBag.language = Language;
            ViewBag.comment = Comment;

            return View();
        }
    }
}
using EduSpire.Models;
using System.Web.Mvc;

namespace EduSpire.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult HighSchool()
        {
            return View();
        }

        public ActionResult College()
        {
            return View();
        }

        public ActionResult GraduateSchool()
        {
            return View();
        }

        public ActionResult TechnicalCollege()
        {
            return View();
        }

        public ActionResult Educators()
        {
            return View();
        }

        public ActionResult _QuizPartial()
        {
            return View("~/Shared/_QuizPartial.cshtml");
        }
    }
}
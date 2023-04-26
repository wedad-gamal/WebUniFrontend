using Microsoft.AspNetCore.Mvc;

namespace WebUniFrontend.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebUniFrontend.Application.Contract;
using WebUniFrontend.Models;

namespace WebUniFrontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseServices _courseServices;

        public HomeController(ILogger<HomeController> logger, ICourseServices courseServices)
        {
            _logger = logger;
            _courseServices = courseServices;
        }

        [HttpGet]
        public IActionResult GetShortCartDataJson()
        {
            return Json(_courseServices.GetCoursesShortCart());
        }

        [HttpGet]
        public IActionResult GetLongCartDataJson()
        {
            return Json(_courseServices.GetCoursesLongCart());
        }
        public IActionResult Index()
        {
            var shortCartitems = _courseServices.GetCoursesShortCart();
            var longCartitems = _courseServices.GetCoursesLongCart();

            var data = new Tuple<List<CourseItem>,
                   List<DetailedCourseItem>>(shortCartitems, longCartitems);

            return View(data);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
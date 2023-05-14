using Microsoft.AspNetCore.Mvc;
using WebUniFrontend.Application.Contract;

namespace WebUniFrontend.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseServices _service;

        public CourseController(ICourseServices courseServices)
        {
            _service = courseServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            //var item = _service.get
            return View();
        }
    }
}

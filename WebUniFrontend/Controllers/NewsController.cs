using Microsoft.AspNetCore.Mvc;

namespace WebUniFrontend.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

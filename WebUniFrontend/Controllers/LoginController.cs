using Microsoft.AspNetCore.Mvc;

namespace WebUniFrontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

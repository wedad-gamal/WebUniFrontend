using Microsoft.AspNetCore.Mvc;

namespace WebUniFrontend.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

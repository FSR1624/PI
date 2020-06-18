using Microsoft.AspNetCore.Mvc;

namespace FirmaMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

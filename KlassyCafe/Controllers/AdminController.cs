using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using KlassyCafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KlassyCafe.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}

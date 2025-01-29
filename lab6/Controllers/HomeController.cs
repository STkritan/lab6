using System.Diagnostics;
using lab6.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            // No logger field is needed now
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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

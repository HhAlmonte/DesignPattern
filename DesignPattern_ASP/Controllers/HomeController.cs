using DesignPattern_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tools;

namespace DesignPattern_ASP.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            Log.GetInstance("log.txt").Save("Hello World");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance("log.txt").Save("Hello World");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
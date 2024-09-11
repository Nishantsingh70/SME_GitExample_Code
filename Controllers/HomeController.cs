using Microsoft.AspNetCore.Mvc;
using SME_GitExample_Code.Models;
using System.Diagnostics;

namespace SME_GitExample_Code.Controllers
{
    public class HomeController : Controller
    {
        int test = 100;
        int b = 2;
        //int a = 1;
        //string name = "nishant";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("This is index page code");
        }

        public IActionResult Privacy()
        {
            return Content("This is privacy page code");
        }

        public IActionResult Login()
        {
            return Content("This is login page code");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

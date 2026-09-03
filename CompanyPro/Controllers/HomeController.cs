using System.Diagnostics;
using CompanyPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /* Action | Endpoint  => Pascal : SayHello, GetAll, GetById
            must be public
            can't be overloaded
            can't be overrided
            can't be static
         */

        public string Greet()
        {
            return "Hey G4";
        }

        public ContentResult SayHello()
        {
            var result = new ContentResult();
            result.Content = "Hello All";
            return result;
        }

        public ViewResult ShowView()
        {
            var result = new ViewResult();
            result.ViewName = "MyView";
            return result;
        }

        // Parent p = new Child();

        public IActionResult ShowMix(int id)
        {
            if(id %2 == 0)
            {
                var result = new ContentResult();
                result.Content = "Hello All";
                return result;
            }
            else
            {
                var result = new ViewResult();
                result.ViewName = "MyView";
                return result;
            }
        }

        // /home/index
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

using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class StateController : Controller
    {
        //private static int count = 0;
        public StateController()
        {
            
        }

        ////http://localhost:5201/state/increment
        ////http://localhost:5201/state/increment
        //public IActionResult Increment()
        //{
        //    count++;
        //    return Content($"Count = {count}");
        //}

        // StateManagement
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Men3m");
            HttpContext.Session.SetInt32("Age", 28);

            return Content("Data Saved on session");
        }

        public IActionResult GetSession()
        {
            var name = HttpContext.Session.GetString("Name");
            var age = HttpContext.Session.GetInt32("Age");
            return Content($"Name = {name}, Age = {age}");
        }


        //Cookie Types
        //     1. Session Cookie
        //     2. Persistance Cookie

        public IActionResult SetCookie() // set on client browser, pass to response
        {
            var cookieOptions = new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddDays(1).AddMinutes(-5) // 23:55:00
                //Expires = DateTimeOffset.Now.AddSeconds(30)          // 00:00:30
            };

            HttpContext.Response.Cookies.Append("Fname", "Zinab", cookieOptions);
            HttpContext.Response.Cookies.Append("Age", "20", cookieOptions);

            return Content("Data Saved on cookies");
        }

        public IActionResult GetCookie() // get from client request
        {
            var fname = HttpContext.Request.Cookies["Fname"];
            var age = int.Parse(HttpContext.Request.Cookies["Age"]!);
            return Content($"Fname = {fname}, Age = {age}");
        }

    }
}

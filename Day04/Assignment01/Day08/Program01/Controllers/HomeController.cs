using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Program01.Models;

namespace Program01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String user = "riya";

            ViewData["Msg"] = "hello" + user;
            ViewData["Count"] = 10;
            ViewBag.Count = 20;
            TempData["Welcome"] = "Welcome.....";

            //return View();
            return RedirectToAction(nameof(Print));
        }

        public IActionResult Print()
        {
            ViewBag.Print = "Good Morning";
            return View();
        }
    }
}

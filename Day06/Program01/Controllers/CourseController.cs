using Microsoft.AspNetCore.Mvc;

namespace Program01.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Program01.Models;

namespace Program01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Sp1Context Sp1 = new Sp1Context();
        public HomeController(ILogger<HomeController> logger)
        {
          
        }

        public IActionResult Index()
        {
            return View(Sp1.Student.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AfterCreate(Student s)
        {
            Sp1.Student.Add(s);
            Sp1.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Edit(int id)
        {
            return View(Sp1.Student.Find(id));
        }


        public IActionResult Delete(int id)
        {
            return View(Sp1.Student.Find(id));
        }
    }


      /*  public ActionResult Delete(int Id)
       {
            var studentToDelete = Sp1.Student.FirstOrDefault(s => s.Id == Id);
            if (studentToDelete != null)
            {
                Sp1.Student.Remove(studentToDelete);
                
            }
            return View(); 
        }*/

    
}

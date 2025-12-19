using System.Diagnostics;
using Assignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        Spcontext sp = new Spcontext();

        public IActionResult Index()
        {

            List<Student> slist = sp.Student.ToList();

            return View("Index", slist);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AfterCreate()
        {
            //sp.Student.Add(s);
            sp.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Edit()
        {
            //Student s1 = sp.Student.Find(id);
            //return View(s1);
        }

        public IActionResult AfterEdit()
        {
           // Student s1 = sp.Student.Find(s, id);
           // s1.FirstName = sp.FirstName;
            //s1.LastName = sp.CourseName;
            sp.SaveChanges();
            return Redirect("/Home/Index");
        }
        public IActionResult Delete()
        {

            Student s1 = sb.Student.Find(id);
            sb.Student = s1.Remove(id);
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }

        
      
    }
}

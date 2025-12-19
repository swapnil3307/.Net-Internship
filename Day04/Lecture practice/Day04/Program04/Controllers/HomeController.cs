using Microsoft.AspNetCore.Mvc;
using Program04.Models;
using System.Diagnostics;

namespace Program04.Controllers
{
    public class HomeController : Controller
    {
         Sbcontacts1 sb = new Sbcontacts1();

        public IActionResult Index()
        {
            List<Student>slist =sb.Student.ToList();

            return View("Index",slist);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AfterCreate(Student s)
        {
            sb.Student.Add(s);
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Edit(int id)
        { 
            Student s1 = sb.Student.Find(id);
            return View(s1);
        }

        public IActionResult AfterEdit(Student id)
        {
            Student s1 = sb.Student.Find(s,id);
            s1.Name = sb.Name;
            s1.CourseName = sb.CourseName;
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Deletet(int id)
        {
     
            Student s1 = sb.Student.Find(id);
            sb.Student = s1.Remove(id);
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Program01.Models;

namespace Program01.Controllers
{
    public class StudentController: Controller
    {
        Sp1Context Sp1 = new Sp1Context();
        
        public IActionResult Index()
        {
            return View(Sp1.Student.Include(c => c.Course).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Course = new SelectList(Sp1.Courses.ToList(),"CourseId","CourseName");
            return View();
        }

        public IActionResult AfterCreate(Student s)
        {
            Sp1.Student.Add(s);
            Sp1.SaveChanges();
            return Redirect("/Student/Index");
        }

        public IActionResult Edit(int id)
        {

            Student s = Sp1.Student.Find(id);
            ViewBag.Courses = new SelectList(Sp1.Courses.Where(c => c.CourseId == s.CourseId), "CourseId", "CourseName");
            return View(Sp1.Student.Find(id));
        }

        public IActionResult AfterEdit(Student s)
        {
            Sp1.Student.Update(s);
            Sp1.SaveChanges();
            return Redirect("/Student/Index");
        }

        public IActionResult Delete(int id)
        {
            Student s1=Sp1.Student.Find(id);
            ViewBag.Courses = new SelectList(Sp1.Courses.Where(b => b.CourseId == s1.CourseId), "CourseId", "CourseName");
            return View(Sp1.Student.Find(id));
        }

        public IActionResult AfterDelete(int id)
        {
            Student s = Sp1.Student.Find(id);
            Sp1.Student.Remove(s);
            Sp1.SaveChanges();
            return Redirect("/Student/Index");
        }

        /*public IActionResult Index()
        {
            var slist = Sp1.Student.Include(s => s.Course).ToList();
            return View(slist);
        }*/
    }
}

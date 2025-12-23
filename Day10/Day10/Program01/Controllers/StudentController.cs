using Microsoft.AspNetCore.Mvc;
using Program01.Filters;
using Program01.Models;

namespace Program01.Controllers
{
    public class StudentController : Controller
    {

        private static List<Student> students = new()
       {
           new Student { Id = 1,Name = "Raj", Email = "raj@gmail.com", CourseId =112 }
       };


        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);


            if (student == null)
            {
                throw new StudentNotFoundException("Student Record Not Found");
            }
            return View(student);
        }

        public IActionResult Index()
        {
            return View(students);
        }

        //public IActionResult DisplayStudent()
        //{
        //    return View(students);
        //}

        public IActionResult Error()
        {
            return View();
        }
    }
}

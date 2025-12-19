using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Program02
{
    internal class Program
    {
        static StudentContext sb = new StudentContext();
        static void Main(string[] args)
        {

      //      List<Student> stud = GetAllStudent();
    //        List<Course> crc = GetAllCourse();

            foreach (var student in stud)
            {
                Console.WriteLine($"Student Id : {student.StudentId} Name : {student.Name}  Age: {student.Age} Course Id: {Course.CourseId}  Course Name: {Course.CourseName}");
            }

            foreach (var stdt in Student)
            {
                Console.WriteLine($"Student Id : {student.StudentId} Name : {student.Name} Age: {student.Age} Course Id: {ECourse.CourseId} Course Name: {student.EnrolledCourse.CourseName}");
            }


            Student sp = FindStudent();
            Console.WriteLine($"Student Id : {sp.StudentId} Name : {sp.Name}    Age : {sp.Age}");

            Console.WriteLine("Updating student : " + Update());
            Console.WriteLine("Deleting student : " + Delete());
        }



        public static List<Course> GetAllCourse()
        {
            return sb.Course.ToList();
        }

        public static List<Student> GetAllStudent()
        {
            return sb.Student.ToList();
        }

        public static int Add()
        {
            Student s = new Student
            {
                Name = "riya"
            };
            sb.Student.Add(s);
            return sb.SaveChanges();
        }

        public static int Update() 
        {
            Student s = sb.Student.Find(7);
            s.Name = "Jay";
            // sb.Student.Add(s);
            return sb.SaveChanges();
        }

        public static int Delete()
        {
            Student s = sb.Student.Find(9);
            sb.Student.Remove(s);
            return sb.SaveChanges();
        }

        public static Student FindStudent()
        {
            Student s = sb.Student.Find(5);
            return s;
        }



    }











    [Table("Student3")]

    class Student
    {
        [Key]
        public int StudentId { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }

        //public List<Course> ECourse { get; set; }
        public Course ECourse { get; set; }
    }


    [Table("Course3")]
    class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        public Student Student { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=Swapinfo;Trusted_Connection =True;");
        }
    }
}

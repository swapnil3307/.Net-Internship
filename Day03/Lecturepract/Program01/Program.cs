using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Program01
{
    internal class Program
    {
        static Sbcontacts sb = new Sbcontacts();
        static void Main(string[] args)
        {
            List<Student> studt = GetAllStudent();

            foreach (var student in studt)
            {
                Console.WriteLine($"Roll no : {student.Rollno} Name : {student.Name} ");
            }


            Console.WriteLine("CRUD Opperations");
            Console.WriteLine("1.To Add \n 2.To Find \n 3.To Update \n 4. To delete");
            Student sp = null;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: Add();
                    break;
            }

            //Console.WriteLine("Row affected : " +Add());
            Student s = FindStudent();
            Console.WriteLine($"Name:{s.Name} RollNo:{s.Rollno}");
           
           Console.WriteLine("Updating student : " + Update());
           Console.WriteLine("Deleting student : " + Delete());
        }


public static int Update()
        {
            Student s = sb.Student.Find(3);
            s.Name = "gita";
           // sb.Student.Add(s);
            return sb.SaveChanges();
        }

        public static List<Student> GetAllStudent()
        {
            return sb.Student.ToList();
        }

        public static int Delete()
        {
            Student s = sb.Student.Find(10);
            sb.Student.Remove(s);
            return sb.SaveChanges();
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
        public static Student FindStudent()
        {
            Student s = sb.Student.Find(11);
            return s;
        }



     }




        public class Student
        {

            [Key]
            public int Rollno { get; set; }

            public string Name { get; set; }
        }


    }



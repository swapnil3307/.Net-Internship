using System.ComponentModel.DataAnnotations;

namespace Program01.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public String CourseName { get; set; }

        public List<Student>Student {  get; set; } 
    }
}

using System.ComponentModel.DataAnnotations;

namespace Program01.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [StringLength(50,ErrorMessage ="Name cannot Exceed 50 character")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Course Selection is Required")]
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}

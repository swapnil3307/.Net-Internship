using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Program01.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PRN { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } = null;
        public int CourseGroupId { get; set; }
        public CourseGroup CourseGroup { get; set; } = null;
        public ICollection<Mark> Mark { get; set; } = new List<Mark>();
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

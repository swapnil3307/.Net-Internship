namespace Assignment01.Models
{
        public class Course
        {
            Spcontext sp = new Spcontext();
            public int CourseId { get; set; }

            public String CourseName { get; set; }
            public int StudentId { get; set; }
            public Student Student { get; set; }
        }
    }
}

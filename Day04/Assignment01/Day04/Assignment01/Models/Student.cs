namespace Assignment01.Models
{
    public class Student
    {
        Spcontext sp = new Spcontext();
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Courses { get;   set; }
     }
  
}

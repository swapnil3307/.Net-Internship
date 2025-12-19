using Microsoft.EntityFrameworkCore;

namespace Program04.Models
{
    public class Student
    {
         Sbcontacts1 sb = new Sbcontacts1();
        public int Id { get; set; }

        public string Name { get; set; }

        public string CourseName { get; set; }
    }

    
}

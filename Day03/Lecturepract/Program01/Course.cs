using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Program01
{
    class Course
    {
        [Key]
        public int Courseid { get; set; }

        public int Name { get; set; }
    }
}

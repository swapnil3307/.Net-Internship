namespace Program01.Models
{
    public class Mark
    {
        public int MarkId { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TheoryMarks { get; set; }
        public int LabMarks { get; set; }
        public int InternalMarks { get; set; }

        /*
         public int TotalMarks=> TheoryMarks + LabMarks +  InternalMarks; 
          
        */

    }
}

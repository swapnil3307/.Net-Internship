namespace Program01.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int CourseId { get; set; }

        public Course Course { get; set; } = null!;

        public int MaxTheoryMarks { get; set; } = 40;

        public int MinTheoryMarks { get; set; } = 40;

        public int MaximumInternalMarks { get; set; } = 20;

        public int PassingPercentTotal { get; set; } = 40;

        public int PassingPercentEachComponent { get; set; } = 40;

        public Mark Marks { get; set; }
    }
}

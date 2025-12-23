namespace Program01.Filters
{
    public class StudentNotFoundException: Exception
    {
        public StudentNotFoundException(string message) : base(message)
        {
        }
    }
}

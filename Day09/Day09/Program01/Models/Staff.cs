namespace Program01.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string? Mobile { get; set; }

        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

namespace Mozg.DB.Models
{
    public class UserStatistics
    {
        public Guid Id { get; set; }
        public Guid UserPlatformID { get; set; }
        public int TotalTasksSolved { get; set; } = 0;
        public int MissedDays { get; set; } = 0;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public UserPlatform UserPlatform { get; set; }
    }
}

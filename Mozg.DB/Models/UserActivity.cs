namespace Mozg.DB.Models
{
    public class UserActivity
    {
        public Guid Id { get; set; }
        public Guid UserPlatformId { get; set; }
        public DateTime Date { get; set; }
        public string ActivityDetails { get; set; }

        public UserPlatform UserPlatform { get; set; }
    }
}

using Mozg.DB.Enums;

namespace Mozg.DB.Models
{
    public class UserPlatform
    {
        public Guid UserPlatformID { get; set; }
        public Guid UserID { get; set; }
        public Platform PlatformType { get; set; }
        public string PlatformID { get; set; }

        public User User { get; set; }

        public ICollection<UserActivity> UserActivities { get; set; }
    }
}

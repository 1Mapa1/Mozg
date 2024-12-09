using Microsoft.EntityFrameworkCore;
using Mozg.DB.Models;

namespace Mozg.DB
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UserActivitys { get; set; }
        public DbSet<UserPlatform> UserPlatforms { get; set; }
        public DbSet<UserStatistics> UserStatistics { get; set; }
        public DbSet<Quiz> Quiz { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
    }
}

namespace CoursePaper.Models
{
    using Microsoft.EntityFrameworkCore;
    public class UserDBContext : DbContext
    {
        DbSet<User> _users;

        public UserDBContext(DbContextOptions<UserDBContext> options) :  base(options) { }
    }
}

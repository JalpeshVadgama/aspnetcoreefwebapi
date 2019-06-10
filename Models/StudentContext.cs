using Microsoft.EntityFrameworkCore;

namespace CoolApi.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
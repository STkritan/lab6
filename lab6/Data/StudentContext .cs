using lab6.Models;
using Microsoft.EntityFrameworkCore;

namespace lab6.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } // Matches the `Student` model
    }
}

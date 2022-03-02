using Microsoft.EntityFrameworkCore;

namespace Api.Workshop.Models
{
    public class RegistrarContext : DbContext
    {
        public RegistrarContext(DbContextOptions<RegistrarContext> options) 
            :base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
    }
}
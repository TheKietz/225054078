using Lab07.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Data
{
    public class UEFContext : DbContext
    {
        public UEFContext(DbContextOptions<UEFContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student");
            modelBuilder.Entity<Enrollment>()
                .ToTable("Enrollment");
            modelBuilder.Entity<Course>()
                .ToTable("Course");
        }
    }
}

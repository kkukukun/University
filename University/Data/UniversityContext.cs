using University.Models;
using Microsoft.EntityFrameworkCore;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Attendance>().ToTable("Attendance");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}

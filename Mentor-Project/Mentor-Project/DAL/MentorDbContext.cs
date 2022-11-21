using Mentor_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor_Project.DAL
{
    public class MentorDbContext : DbContext
    {
        public MentorDbContext(DbContextOptions<MentorDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
    }  
}

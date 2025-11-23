using Microsoft.EntityFrameworkCore;

namespace online_learning_platform.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Entities.User> Users { get; set; }
        public DbSet<Models.Entities.Course> Courses { get; set; }
        public DbSet<Models.Entities.Category> Categories { get; set; }
        public DbSet<Models.Entities.CourseCategory> CourseCategories { get; set; }
        public DbSet<Models.Entities.Enrollment> Enrollments { get; set; }
        public DbSet<Models.Entities.Quiz> Quizzes { get; set; }
        public DbSet<Models.Entities.QuizResult> QuizResults { get; set; }
        public DbSet<Models.Entities.Review> Reviews { get; set; }
    }
}
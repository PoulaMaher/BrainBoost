using BrainBoost_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BrainBoost_API
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<subscription> Subscriptions { get; set; }
        public DbSet<FacebookUser> FacebookUsers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Question>()
            .HasMany(q => q.Answers)
            .WithOne(a => a.Question)
            .HasForeignKey(a => a.QuestionId);

                builder.Entity<Question>()
                .HasOne(q => q.TrueAnswer)
                .WithMany()
                .HasForeignKey(q => q.TrueAnswerId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Course>()
              .HasOne(e => e.Teacher)
              .WithMany()
              .HasForeignKey(e => e.TeacherId)
               .OnDelete(DeleteBehavior.NoAction);

            }


    }
}

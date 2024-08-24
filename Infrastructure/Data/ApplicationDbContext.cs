using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<User>(options)
    {

        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseMuscle> ExerciseMuscle { get; set; }
        public DbSet<ExerciseTraining> ExerciseTraining { get; set; }
        public DbSet<Muscle> Muscle { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

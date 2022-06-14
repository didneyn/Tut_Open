using Microsoft.EntityFrameworkCore;
using csharp_exercises_open.Models.DataModels;

namespace csharp_exercises_open.DataAccess
{
        public class UniversityContext: DbContext
        {
            public UniversityContext(DbContextOptions<UniversityContext> options): base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                /*
                modelBuilder.Entity<User>().HasOne(x => x.CreateBy).WithMany(x => x.UsersCreate).OnDelete(DeleteBehavior.Restrict);
                modelBuilder.Entity<User>().HasOne(x => x.UpdateBy).WithMany(x => x.UsersUpdate).OnDelete(DeleteBehavior.Restrict);
                modelBuilder.Entity<User>().HasOne(x => x.DeletedBy).WithMany(x => x.UsersDeleted).OnDelete(DeleteBehavior.Restrict);
                */
            }

            public DbSet<Category>? Categories { get; set; }
            public DbSet<Chapter>? Chapters { get; set; }
            public DbSet<Course>? Courses { get; set; }
            public DbSet<Objective>? Objectives { get; set; }
            public DbSet<PrincipalObjective>? PrincipalObjectives { get; set; }
            public DbSet<Student>? Students { get; set; }
            public DbSet<User>? Users { get; set; }


        }
}
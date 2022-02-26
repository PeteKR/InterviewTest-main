using InterviewTestExercise.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterviewTestExercise.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student(1, "John", "Doe"));
            modelBuilder.Entity<Student>().HasData(new Student(2, "Anna", "Evermore"));
            modelBuilder.Entity<Student>().HasData(new Student(3, "Tom", "Jerry"));
            modelBuilder.Entity<Student>().HasData(new Student(4, "Becky", "McCarthy"));
            modelBuilder.Entity<Student>().HasData(new Student(5, "Patrick", "Star"));
            modelBuilder.Entity<Student>().HasData(new Student(6, "Alice", "Anderson"));
            modelBuilder.Entity<Student>().HasData(new Student(7, "Chris", "Long"));
            modelBuilder.Entity<Student>().HasData(new Student(8, "Jack", "Wonderland"));
            modelBuilder.Entity<Student>().HasData(new Student(9, "Clive", "Ferry"));
            modelBuilder.Entity<Student>().HasData(new Student(10, "Alan", "Borson"));

            modelBuilder.Entity<Grade>().HasData(new Grade(1, 2) { StudentId = 1 });
            modelBuilder.Entity<Grade>().HasData(new Grade(2, 3) { StudentId = 1 });
            modelBuilder.Entity<Grade>().HasData(new Grade(3, 4) { StudentId = 1 });

            modelBuilder.Entity<Grade>().HasData(new Grade(4, 5) { StudentId = 2 });
            modelBuilder.Entity<Grade>().HasData(new Grade(5, 4) { StudentId = 2 });

            modelBuilder.Entity<Grade>().HasData(new Grade(6, 2) { StudentId = 3 });
            modelBuilder.Entity<Grade>().HasData(new Grade(7, 3) { StudentId = 3 });
            modelBuilder.Entity<Grade>().HasData(new Grade(8, 2) { StudentId = 3 });

            modelBuilder.Entity<Grade>().HasData(new Grade(9, 3) { StudentId = 4 });
            modelBuilder.Entity<Grade>().HasData(new Grade(10, 2) { StudentId = 4 });

            modelBuilder.Entity<Grade>().HasData(new Grade(11, 3) { StudentId = 5 });
            modelBuilder.Entity<Grade>().HasData(new Grade(12, 5) { StudentId = 5 });
            modelBuilder.Entity<Grade>().HasData(new Grade(13, 4) { StudentId = 5 });

            modelBuilder.Entity<Grade>().HasData(new Grade(14, 5) { StudentId = 6 });
            modelBuilder.Entity<Grade>().HasData(new Grade(15, 5) { StudentId = 6 });

            modelBuilder.Entity<Grade>().HasData(new Grade(16, 3) { StudentId = 7 });
            modelBuilder.Entity<Grade>().HasData(new Grade(17, 2) { StudentId = 7 });

            modelBuilder.Entity<Grade>().HasData(new Grade(18, 3) { StudentId = 8 });
            modelBuilder.Entity<Grade>().HasData(new Grade(19, 5) { StudentId = 8 });
            modelBuilder.Entity<Grade>().HasData(new Grade(20, 4) { StudentId = 8 });

            modelBuilder.Entity<Grade>().HasData(new Grade(21, 5) { StudentId = 9 });
            modelBuilder.Entity<Grade>().HasData(new Grade(22, 5) { StudentId = 9 });

            modelBuilder.Entity<Grade>().HasData(new Grade(23, 3) { StudentId = 10 });
            modelBuilder.Entity<Grade>().HasData(new Grade(24, 2) { StudentId = 10 });
            modelBuilder.Entity<Grade>().HasData(new Grade(25, 2) { StudentId = 10 });

            base.OnModelCreating(modelBuilder);
        }
    }
}

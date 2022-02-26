using InterviewTestExercise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTestExercise.Persistance.Configurations
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.IdStudent);
            builder.Property(s => s.FirstName).IsRequired();
            builder.Property(s => s.LastName).IsRequired();

            builder.HasMany<Grade>(g => g.Grades)
                   .WithOne(s => s.Student)
                   .HasForeignKey(si => si.StudentId);
        }
    }
}

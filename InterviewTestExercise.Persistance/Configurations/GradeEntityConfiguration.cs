using InterviewTestExercise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestExercise.Persistance.Configurations
{
    public class GradeEntityConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(g => g.IdGrade);

            builder.HasOne<Student>(s => s.Student)
                   .WithMany(g => g.Grades)
                   .HasForeignKey(gi => gi.IdGrade);
        }
    }
}

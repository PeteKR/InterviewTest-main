using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Entities
{
    public class Student
    {
        public Student(int idStudent, string firstName, string lastName)
        {
            IdStudent = idStudent;
            FirstName = firstName;
            LastName = lastName;
        }

        [Key]
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AverageGrade { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Entities
{
    
    public class Grade
    {
        public Grade(int idGrade, int grade)
        {
            IdGrade = idGrade;
            GivenGrade = grade;
        }

        public Grade() { }

        [Key]
        public int IdGrade { get; set; }
        public int GivenGrade { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
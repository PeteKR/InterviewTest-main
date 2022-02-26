using InterviewTestExercise.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        double GetGrade(ICollection<Grade> grades);
        IEnumerable<Grade> AddGrade(int studentId,int grade);
    }
}

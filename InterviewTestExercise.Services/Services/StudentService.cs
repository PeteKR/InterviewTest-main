using InterviewTestExercise.Domain.Entities;
using InterviewTestExercise.Domain.Interfaces.Services;
using InterviewTestExercise.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTestExercise.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            await _dbContext.Database.EnsureCreatedAsync();
            var allStudentList = await _dbContext.Students.ToListAsync();
            await _dbContext.Grades.ToListAsync();
            foreach(var item in allStudentList)
            {
                item.AverageGrade = GetGrade(item.Grades);
            }
            _dbContext.SaveChanges();
            return allStudentList;
        }

        public double GetGrade(ICollection<Grade> grades)
        {
            double averageGradeList = grades.Average(g => g.GivenGrade);
            return averageGradeList;
        }

        public IEnumerable<Grade> AddGrade(int studentId, int grade)
        {
            var gradeId = _dbContext.Grades.Where(g => g.StudentId == studentId).Last();
            var newGrade = new Grade() { GivenGrade = grade, IdGrade = (gradeId.IdGrade+1) };
            newGrade.StudentId = studentId;
            _dbContext.Grades.Add(newGrade);
            _dbContext.SaveChanges();
            return _dbContext.Grades.ToList();
        }
    }
}

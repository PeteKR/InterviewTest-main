using InterviewTestExercise.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTest.UI.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService service)
        {
            _studentService = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _studentService.GetStudentsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(int id)
        {
            //_studentService.AddGrade(studentId, grade);
            System.Console.WriteLine(id);
            Thread.Sleep(2222);
            return await Index();
        }
    }
}

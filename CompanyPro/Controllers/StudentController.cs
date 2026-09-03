using CompanyPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetAll()
        {
            StudentRepository studentRepository = new();
            var studentsModel = studentRepository.GetAllStudents();
            return View("ShowAllStudents", studentsModel);
        }
        
        public IActionResult GetById(int id)
        {
            StudentRepository studentRepository = new();
            var studentsModel = studentRepository.GetStudentById(id);
            return View("ShowAllStudents", studentsModel);
        }
    }
}

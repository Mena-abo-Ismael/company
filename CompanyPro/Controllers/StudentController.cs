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
            return View("ShowStudentDetails", studentsModel);
        }
        
        //public IActionResult Action1(int id)
        //{
        //    var result = new ViewResult();
        //    result.ViewName = "abc";
        //    return result;

        //}
        
        //public IActionResult Action2(int id)
        //{
        //    var result = new ViewResult();
        //    result.ViewName = "abc";
        //    return result;
        //}
        
        //public IActionResult Action3(int id)
        //{
        //    return CreateView("test");
        //}

        //private ViewResult CreateView(string viewName)
        //{
        //    var result = new ViewResult();
        //    result.ViewName = viewName;
        //    return result;
        //}
    }
}

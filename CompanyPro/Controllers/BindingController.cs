using CompanyPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class BindingController : Controller
    {
        ////https://localhost:7234/binding/testprimitive?name=omar&age=22&id=11
        ////https://localhost:7234/binding/testprimitive/11?name=omar&age=22
        //public IActionResult TestPrimitive(int age, string name, int id)
        //{
        //    return Content($"age={age}, name={name}");
        //}

        ////https://localhost:7234/binding/TestArray?colors=red&colors=blue       [0:red, 1:blue]
        ////https://localhost:7234/binding/TestArray?colors[1]=red&colors=blue   [0:blue]
        ////https://localhost:7234/binding/TestArray?colors=red&colors[1]=blue   [0:red]
        ////https://localhost:7234/binding/TestArray?colors[0]=red&colors[1]=blue [0:red, 1:blue]
        ////https://localhost:7234/binding/TestArray?colors[1]=red&colors[0]=blue [0:blue, 1:red]
        //public IActionResult TestArray(int age, string[] colors)
        //{
        //    return Content($"age={age}");
        //}

        ////https://localhost:7234/binding/TestDic?phones[youssef]=122&phones[omar]=124
        ////https://localhost:7234/binding/TestDic?phones[youssef]=122&phones[omar]=124&location=iti
        //public IActionResult TestDic(Dictionary<string, string> phones, string location)
        //{
        //    return Content("ok");
        //}


        ////https://localhost:7234/binding/TestComplex?did=12&name=SD&locaTioN=Menoufia
        ////https://localhost:7234/binding/TestComplex?name=SD&locaTioN=Menoufia&did=12&name=iti
        ////https://localhost:7234/binding/TestComplex?name=SD&locaTioN=Menoufia&did=12&name=iti&Employees[0].eid=100&Employees[0].Name=ahmed
        ////https://localhost:7234/binding/TestComplex?name=SD&locaTioN=Menoufia&did=12&name=iti&Employees[1].eid=100&Employees[1].Name=ahmed
        ////https://localhost:7234/binding/TestComplex?name=SD&locaTioN=Menoufia&did=12&name=iti&Employees[0].eid=100&Employees[0].Name=ahmed&Employees[1].eid=101&Employees[1].Name=mohamed
        // map url params on objects' properties
        //public IActionResult TestComplex(Department dept, string name)
        //{
        //    return Content("ok");
        //}


    }
}

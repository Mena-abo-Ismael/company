using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace CompanyPro.Models
{
    public class StudentRepository
    {
        private List<Student> students;
        public StudentRepository()
        {
            students = new List<Student>()
            {
                new Student() {Id = 1, Name = "Lena", Age = 18, DeptId = 1, ImageUrl="female.webp"},
                new Student() {Id = 2, Name = "Mohamed Ibrahem", Age = 20, DeptId = 2, ImageUrl="male.webp"},
                new Student() {Id = 1, Name = "Menna", Age = 19, DeptId = 1, ImageUrl="female.webp"},
                new Student() {Id = 2, Name = "Mahmoud", Age = 21, DeptId = 3, ImageUrl="male.webp"},
            };
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }

    }
}

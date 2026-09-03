namespace CompanyPro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Age = {Age}, DeptId = {DeptId}, ImageUrl={ImageUrl}";
        }
    }
}

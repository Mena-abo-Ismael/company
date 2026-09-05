namespace CompanyPro.ViewModels
{
    public class GetAllEmployeesViewModel
    {
        public int Eid { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public List<string> Branches { get; set; } = new();
        public int Temp { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}

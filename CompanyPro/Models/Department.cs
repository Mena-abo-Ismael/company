using System.ComponentModel.DataAnnotations;

namespace CompanyPro.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        
        [MaxLength(50)]
        [MinLength(10)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Location { get; set; } = string.Empty;

        public virtual ICollection<Employee> Employees { get; set; }// = new List<Employee>();
    }
}


/**
 *    void xyz(Parent p) {}
 * 
 *   xyz(new Child())
 * 
 */ 

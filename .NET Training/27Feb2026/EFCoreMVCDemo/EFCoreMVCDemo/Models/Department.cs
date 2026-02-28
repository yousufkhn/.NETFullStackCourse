using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCDemo.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

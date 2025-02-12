using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyMvcApp.Models;

namespace MyMvcApp.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int Id { get; set; }  

        [Required]
        public string DeptName { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int? FKDeptId { get; set; } 

        [Required] 
        public string? EmpName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }


        public virtual Department? Department { get; set; }
    }
}

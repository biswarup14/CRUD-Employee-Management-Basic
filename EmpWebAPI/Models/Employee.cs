using System.ComponentModel.DataAnnotations;

namespace EmpWebAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }   
        public string? Age { get; set; } 
        public int IsActive { get; set; }
    }

}

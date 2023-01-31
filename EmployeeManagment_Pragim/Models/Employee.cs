using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15,ErrorMessage ="Name cannot be exceed than 15 Characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Office Email")]
        public string Email { get; set; }

        [Required]
        public Department? Department { get; set; }
    }
}

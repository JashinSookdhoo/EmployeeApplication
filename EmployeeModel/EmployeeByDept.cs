using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{

    public class EmployeeByDept
    {
        [Key]
        [Required(ErrorMessage = "Please enter an Employee ID")]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string Sex { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Department ID")]
        public string DepartmentId { get; set; }

        [Display(Name = "Random Text")]
        public string Random { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}

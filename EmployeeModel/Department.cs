using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Department
    {

        [Key]
        [Display(Name = "Department ID")]
        public string DepartmentId { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Sequence Number")]
        public int SeqNo { get; set; }
    }
}

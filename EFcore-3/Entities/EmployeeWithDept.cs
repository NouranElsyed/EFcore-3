using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Entities
{
    [Table("Employees")]
    public class EmployeeWithDept
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("DeptID")]
        public virtual Department WorkFor { get; set; }
    }
}

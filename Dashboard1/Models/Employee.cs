using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public bool isDeleted { get; set; }


        [ForeignKey("Manager")]
        public int? Manager_Id { get; set; }
        public Employee Manager { get; set; }

        [ForeignKey("Department")]
        public string Department_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<Employee_Role> Employee_Roles { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Employee_Role")]
    public class Employee_Role
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Role")]
        public string Role_Id { get; set; }
        public Role Role { get; set; }

    }
}

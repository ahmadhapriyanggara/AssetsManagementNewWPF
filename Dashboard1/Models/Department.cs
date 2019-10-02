using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Department")]
    public class Department
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }

        [ForeignKey("Division")]
        public string Division_Id { get; set; }
        public Division Division { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

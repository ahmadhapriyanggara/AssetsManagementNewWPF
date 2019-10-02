using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_M_Role")]
    public class Role
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Employee_Role> Employee_Roles { get; set; }
    }
}

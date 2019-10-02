using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_M_Division")]
    public class Division
    {
        [Key]
        public string Id { get; set; }
        public string name { get; set; }
        public string isDeleted { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}

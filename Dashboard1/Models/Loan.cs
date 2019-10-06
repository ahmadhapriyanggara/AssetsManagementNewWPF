using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Loan")]
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        public DateTime Loan_Date { get; set; }
        public DateTime Return_Date { get; set; }
        public string Remark { get; set; }
                
    }
}

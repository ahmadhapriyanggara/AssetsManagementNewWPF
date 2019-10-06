using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Loan_Approve_Status")]
    public class Loan_Approve_Status
    {
        [Key]
        public int Id { get; set; }
        public DateTime Approve_Date { get; set; }

        [ForeignKey("Approve_Status")]
        public int Approve_Status_Id { get; set; }
        public Approve_Status Approve_Status { get; set; }

        [ForeignKey("Loan")]
        public int Loan_Id { get; set; }
        public Loan Loan { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}

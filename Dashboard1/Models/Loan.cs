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

        [ForeignKey("Loan_Approve_Status")]
        public int Loan_Approve_Status_Id { get; set; }
        public Loan_Approve_Status Loan_Approve_Status { get; set; }

        [ForeignKey("Employee_Role")]
        public int Employee_Role_Id { get; set; }
        public Employee_Role Employee_Role { get; set; }


        public ICollection<Item_Loan> Item_Loans { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    [Table("TB_M_Approve_Status")]
    public class Approve_Status
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Loan_Approve_Status> Loans_Approve_Status { get; set; }
    }
}

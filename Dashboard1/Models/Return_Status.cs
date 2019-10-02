using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    [Table("TB_M_Return_Status")]
    public class Return_Status
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Item_Loan_Return_Status> Items_Loan_return_Status { get; set; }

    }
}

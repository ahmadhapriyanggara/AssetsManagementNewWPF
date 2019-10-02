using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    [Table("TB_T_Item_Loan_Return_Status")]
    public class Item_Loan_Return_Status
    {
        [Key]
        public int Id { get; set; }
        public DateTime Return_Status_Date { get; set; }
        [ForeignKey("Return_Status")]
        public int Return_Status_Id { get; set; }
        public Return_Status Return_Status { get; set; }
        public ICollection<Item_Loan> Item_Loans { get; set; }
    }
}

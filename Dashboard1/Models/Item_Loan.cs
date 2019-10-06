using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Models
{
    [Table("TB_T_Item_Loan")]
    public class Item_Loan
    {
        [Key]
        public int Id { get; set; }
        public int Quantity_Loan { get; set; }
        public DateTime Return_Item_Date { get; set; }

        [ForeignKey("Loan")]
        public int loan_id { get; set; }
        public Loan Loan { get; set; }

        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Return_Status")]
        public int Item_LoanReturn_Status_Id { get; set; }
        public Item_Return_Status Return_Status { get; set; }

        [ForeignKey("Supplier")]
        public int Item_Supplier_Id { get; set; }
        public Item_Supplier Supplier { get; set; }
    }
}

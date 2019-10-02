using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Models
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

        [ForeignKey("Item_Supplier")]
        public int Item_Supplier_Id { get; set; }
        public Item_Supplier Item_Supplier { get; set; }

        [ForeignKey("Item_Loan_Return_Status")]
        public int Item_Loan_Return_Status_Id { get; set; }
        public Item_Loan_Return_Status Item_Loan_Return_Status { get; set; }
    }
}

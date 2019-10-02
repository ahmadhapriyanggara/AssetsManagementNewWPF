using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    [Table("TB_T_Item_Supplier")]
    public class Item_Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Serial_Number { get; set; }
        public string Durability { get; set; }
        [ForeignKey("Tb_T_Item")]
        public int Item_Id { get; set; }
        [ForeignKey("Tb_M_Supplier")]
        public int Supplier_Id { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Item_Loan> Item_Loans { get; set; }
        
    }
}

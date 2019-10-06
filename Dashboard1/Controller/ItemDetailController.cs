using Dashboard1.Context;
using Dashboard1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dashboard1.Controller
{
    class ItemDetailController
    {
        public bool AddItem(string Isnumber, string Iscondition, int IsIid, int IsSid)
        {
            var result = 0;
            Item_Supplier itemSupplier = new Item_Supplier();
            MyContext _context = new MyContext();

            itemSupplier.Serial_Number = Isnumber;
            itemSupplier.Condition = Iscondition;
            itemSupplier.Item_Id = IsIid;
            itemSupplier.Supplier_Id = IsSid;
            itemSupplier.isDeleted = false;
            _context.Item_Suppliers.Add(itemSupplier);
            result = _context.SaveChanges();

            return result > 0;

            
        }
    }
}

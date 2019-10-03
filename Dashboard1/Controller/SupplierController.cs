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
    class SupplierController
    {
        public void AddSupplier(string Sname, string Saddress, string Sphone)
        {
            var result = 0;
            Supplier supplier = new Supplier();
            MyContext _context = new MyContext();

            supplier.Name = Sname;
            supplier.Address = Saddress;
            supplier.No_Telp = Sphone;
            supplier.isDeleted = false;
            _context.Suppliers.Add(supplier);
            result = _context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Add Data Supplier Successful!");
            }
            else
            {
                MessageBox.Show("Add Data Supplier Failed!");
            }
        }

        public void UpdateSupplier(int id, string Sname, string Saddress, string Sphone)
        {
            var result = 0;

            Supplier supplier = new Supplier();
            MyContext _context = new MyContext();

            var get = _context.Suppliers.Find(id);

            if (get == null)
            {
                MessageBox.Show("Supplier not found!");
            }
            else
            {
                get.Name = Sname;
                get.Address= Saddress;
                get.No_Telp = Sphone;
                result = _context.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Update Success!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
        }
        public void DeleteSupplier(int id)
        {
            var result = 0;

            Supplier supplier = new Supplier();
            MyContext _context = new MyContext();

            var get = _context.Suppliers.Find(id);

            // pengecekan data di database
            if (get == null)
            {
                // jika tidak ada, maka akan menampilkan seperti berikut
                MessageBox.Show("Sorry, your data is not found");
            }
            else
            {
                // jika ada, maka akan mengubah status isDelete dan akan disimpan di database
                //getData.IsDelete = true;
                //getData.DeleteDate = DateTimeOffset.Now.LocalDateTime;


                // jika ada, maka akan didelete dan akan disimpan di database
                get.isDeleted = true;
                result = _context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Delete Successfully");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }

            }
        }
    }
}

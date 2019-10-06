using Dashboard1.Context;
using Dashboard1.Models;
using Dashboard1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dashboard1.Controller
{
    class ItemController
    {
        public void AddItem(string Iname, int Iqty, int Icat, string Uemail, string Uname, string Uroles)
        {
            var result = 0;
            Models.Item item = new Models.Item();
            MyContext _context = new MyContext();

            item.Name = Iname;
            item.Quantity = Iqty;
            item.Category_Id = Icat;
            item.isDeleted = false;
            _context.Items.Add(item);
            result = _context.SaveChanges();

            for (int i = 0; i < Iqty; i++ ) {
                ItemDetail iDetail = new ItemDetail(Uemail, Uname, Uroles);
                iDetail.ShowDialog();
            }


            if (result > 0)
            {
                MessageBox.Show("Add Data Item Successful!");
            }
            else
            {
                MessageBox.Show("Add Data Item Failed!");
            }
        }

        public void UpdateItem(int id, string Iname, int Iqty, int Icat)
        {
            var result = 0;

            Models.Item item = new Models.Item();
            MyContext _context = new MyContext();

            var get = _context.Items.Find(id);

            if (get == null)
            {
                MessageBox.Show("Supplier not found!");
            }
            else
            {
                get.Name = Iname;
                get.Quantity = Iqty;
                get.Category_Id = Icat;
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

        public void DeleteItem(int id)
        {
            var result = 0;

            Models.Item item = new Models.Item();
            MyContext _context = new MyContext();

            var get = _context.Items.Find(id);

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

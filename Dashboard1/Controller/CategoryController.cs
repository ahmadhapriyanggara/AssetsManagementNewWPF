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
    class CategoryController
    {
        public void AddCategory(string Cname)
        {
            var result = 0;
            Category category = new Category();
            MyContext _context = new MyContext();

            category.Name = Cname;
            category.isDeleted = false;
            _context.Categorys.Add(category);
            result = _context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Add Data Item Category Successful!");
            }
            else
            {
                MessageBox.Show("Add Data Item Category Failed!");
            }
        }

        public void UpdateCategory(int id,string Cname)
        {
            var result = 0;

            Category category = new Category();
            MyContext _context = new MyContext();

            var get = _context.Categorys.Find(id);

            if (get == null)
            {
                MessageBox.Show("Item Category not found!");
            }
            else
            {
                if (get.Name != Cname)
                {
                    get.Name = Cname;
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
                else
                {
                    MessageBox.Show("Your Category Name can't be the same!");
                }
            }
        }

        public void DeleteCategory(int id)
        {
            var result = 0;

            Category user = new Category();
            MyContext _context = new MyContext();

            var get = _context.Categorys.Find(id);

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

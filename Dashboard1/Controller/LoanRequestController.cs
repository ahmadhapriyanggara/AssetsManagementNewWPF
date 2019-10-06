using Dashboard1.Context;
using Dashboard1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Controller
{
    class LoanRequestController
    {
        public void AddLoanRequest(string name)
        {
            var result = 0;
            Item_Loan itemloan = new Item_Loan();
            MyContext _context = new MyContext();

            itemloan.loa
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
    }
}

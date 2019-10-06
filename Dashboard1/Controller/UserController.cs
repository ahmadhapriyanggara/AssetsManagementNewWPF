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
    class UserController
    {
        public bool UserLogin(string email, string pword)
        {

            var status = true;

            User user = new User();
            MyContext _context = new MyContext();

            var get = _context.Users.Where(u => u.Email == email).FirstOrDefault<User>();

            if (get == null)
            {
                MessageBox.Show("You are not Registered yet!");
                status = false;
            }
            else
            {
                if (get.Password != pword)
                {
                    MessageBox.Show("Your Password is Incorrect!");
                    status = false;
                }
                else
                {
                    MessageBox.Show("Login Successful!");
                }
            }
            return status;
        }
    }
}

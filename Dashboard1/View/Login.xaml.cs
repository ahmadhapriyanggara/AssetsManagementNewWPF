using Dashboard1.Controller;
using Dashboard1.Models;
using Dashboard1.Context;
using Dashboard1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string UserRoles;
        public string UserEmail;
        public string UserName;

        UserController callLogin = new UserController();
        public Login()
        {
            InitializeComponent();
            emailTextBox.Text = Properties.Settings.Default.Email;
        }

        private void Checked_rememberme(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Email = emailTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void btn_SignIn(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();

            if (emailTextBox.Text.Length == 0 && passwordTextBox.Password.Length == 0)
            {
                EmailErrorMessage.Text = "Email Can't Be Empty!";
                PasswordErrorMessage.Text = "Password Can't Be Empty!";
                passwordTextBox.Focus();
                emailTextBox.Focus();
            }
            else if (emailTextBox.Text.Length == 0)
            {
                EmailErrorMessage.Text = "Email Can't Be Empty!";
                emailTextBox.Focus();
            }
            else if (passwordTextBox.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "Password Can't Be Empty!";
                passwordTextBox.Focus();
            }
            else
            {
                string email = emailTextBox.Text;
                string password = passwordTextBox.Password;



                var status = CallUser.UserLogin(email, password);
                if (status == true)
                {
                    RolesSetter(email);
                    this.Hide();
                    Dashboard home = new Dashboard(UserEmail, UserName, UserRoles );
                    home.Show();
                }
            }
        }

        private void btn_ForgotPass(object sender, RoutedEventArgs e)
        {
            ForgotPassword callFP = new ForgotPassword();
            callFP.Show();
            Close();
        }

        public void RolesSetter(string uemail)
        {
            User usr = new Models.User();
            Employee_Role empr = new Employee_Role();
            Employee emp = new Employee();
            MyContext _context = new MyContext();

            var get = _context.Users.Join(_context.Employees, u => u.Id, e => e.Id, (u, e) => new
            {
                u,
                e
            }).Join(_context.Employee_Roles, o => o.e.Id, er => er.Employee_Id, (emp1, er) => new { emp1, er }).Select(x => new
            {
                Roles_Id = x.er.Role_Id,
                Name = x.emp1.e.First_Name,
                Email = x.emp1.u.Email
            }).Where(u => u.Email == uemail).FirstOrDefault();

            UserEmail = get.Email;
            UserName = get.Name;
            UserRoles = get.Roles_Id;

            


        }

    }
}

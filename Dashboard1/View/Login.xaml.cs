using AssetManagement.Controller;
using AssetManagement.View;
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

namespace AssetManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        LoginController callLogin = new LoginController();
        public Login()
        {
            InitializeComponent();
            email.Text = Properties.Settings.Default.Email;
        }

        private void Checked_rememberme(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Email = email.Text;
            Properties.Settings.Default.Save();
        }

        //private void btn_SignIn(object sender, RoutedEventArgs e)
        //{
        //    string dataemail = email.Text;
        //    string datapassword = password.Password;

        //    var status = callLogin.login(dataemail, datapassword);
        //    if(status == true)
        //    {
        //        Dashboard dashboard = new Dashboard();
        //        dashboard.Show();
        //        Close();
        //    }
        //}

        private void btn_ForgotPass(object sender, RoutedEventArgs e)
        {
            ForgotPassword callFP = new ForgotPassword();
            callFP.Show();
            Close();
        }
    }
}

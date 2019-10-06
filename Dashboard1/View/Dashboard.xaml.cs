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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Dashboard : Window
    {
        string email;
        string name;
        string roles;
        public Dashboard(string Uemail, string Uname, string Uroles)
        {
            InitializeComponent();
            GlobalSetter(Uemail, Uname, Uroles);
            LoadSideNavBar(Uroles);
            MessageBox.Show(Uroles);

        }

        private void LoadSideNavBar(string RoleId) {
            if (RoleId == "EMP") {
                ButtonSupplier.Visibility = Visibility.Collapsed;
                ButtonItem.Visibility = Visibility.Collapsed;
                ButtonCategory.Visibility = Visibility.Collapsed;
            }
            else if (RoleId == "MAN") {
                ButtonSupplier.Visibility = Visibility.Collapsed;
                ButtonItem.Visibility = Visibility.Collapsed;
                ButtonCategory.Visibility = Visibility.Collapsed;
            }

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            var items = new List<Transaksi_Loanss>();
            items.Add(new Transaksi_Loanss(1,"Printer HP",Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good","Dipinjam"));
            items.Add(new Transaksi_Loanss(2, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loanss(3, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loanss(4, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loanss(5, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void DashboardCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory masterCategory = new MasterCategory(email, name, roles);
            masterCategory.Show();
        }

        private void DashboardDashboard(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(email, name, roles);
            dashboard.Show();
        }

        private void DashboardItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item(email, name, roles);
            item.Show();
        }

        private void DashboardSupplier(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Supplier supplier = new Supplier(email, name, roles);
            supplier.Show();
        }
        public void GlobalSetter(string Uemail, string Uname, string Uroles)
        {
            email = Uemail;
            name = Uname;
            roles = Uroles;
        }
    }


    class Transaksi_Loanss
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }

        public Transaksi_Loanss(int id, string iname, DateTime LDate, DateTime RDate, string remark, string status)
        {
            this.Id = id;
            this.ItemName = iname;
            this.LoanDate = LDate;
            this.ReturnDate = RDate;
            this.Remark = remark;
            this.Status = status;

        }


        

    }


}

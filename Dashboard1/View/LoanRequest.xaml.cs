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
using System.Windows.Shapes;

namespace Dashboard1.View
{
    /// <summary>
    /// Interaction logic for LoanRequest.xaml
    /// </summary>
    public partial class LoanRequest : Window
    {
        public LoanRequest()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            var items = new List<Transaksi_Loan>();
            items.Add(new Transaksi_Loan(1, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loan(2, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loan(3, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loan(4, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            items.Add(new Transaksi_Loan(5, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home NewDashboard = new Home();
            NewDashboard.Show();

        }

        private void btn_LoanRequest(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoanRequest loanrequest = new LoanRequest();
            loanrequest.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.Show();
        }
    }
}

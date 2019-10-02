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
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void AddDataSupplier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateDataSupplier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteDataSupplier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SupplierDashboard(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void SupplierSupplier(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void SupplierItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.Show();
        }

        private void SupplierCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory category = new MasterCategory();
            category.Show();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            var itemsss = new List<Transaksi_Loansss>();
            itemsss.Add(new Transaksi_Loansss(1, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemsss.Add(new Transaksi_Loansss(2, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemsss.Add(new Transaksi_Loansss(3, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemsss.Add(new Transaksi_Loansss(4, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemsss.Add(new Transaksi_Loansss(5, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = itemsss;
        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGrid.SelectedCells != null)
            {
                object item = dataGrid.SelectedItem;

                SupplierNameTextBox.Text = (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            }
        }
    }

    class Transaksi_Loansss
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }

        public Transaksi_Loansss(int id, string iname, DateTime LDate, DateTime RDate, string remark, string status)
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

using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class Item : Window
    {
        public Item()
        {
            InitializeComponent();
            
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            var itemss = new List<Transaksi_Loans>();
            itemss.Add(new Transaksi_Loans(1, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemss.Add(new Transaksi_Loans(2, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemss.Add(new Transaksi_Loans(3, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemss.Add(new Transaksi_Loans(4, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));
            itemss.Add(new Transaksi_Loans(5, "Printer HP", Convert.ToDateTime("11-10-2019"), Convert.ToDateTime("11-10-2019"), "Good", "Dipinjam"));

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = itemss;
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ItemDashboard(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ItemItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.Show();
        }

        private void ItemCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory category = new MasterCategory();
            category.Show();
        }

        private void AddDataItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateDataItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteDataItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGrid.SelectedCells != null) {
                object item = dataGrid.SelectedItem;

                ItemNameTextBox.Text = (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            }
        }
    }

    class Transaksi_Loans
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }

        public Transaksi_Loans(int id, string iname, DateTime LDate, DateTime RDate, string remark, string status)
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

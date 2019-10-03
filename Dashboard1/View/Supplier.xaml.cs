using Dashboard1.Context;
using Dashboard1.Controller;
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
        private string Gname;
        private string Gaddress;
        private string Gphone;
        private object item;

        public Supplier()
        {
            InitializeComponent();
        }

        private void AddDataSupplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierController CallSupplier = new SupplierController();


            if (SupplierNameTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0 && SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierNameTextBox.Focus();
                SupplierAddressTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0 && SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierNameTextBox.Focus();
                SupplierAddressTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierNameTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierAddressTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierAddressTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierAddressTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierNameTextBox.Focus();
            }
            else
            {
                string Sname = SupplierNameTextBox.Text;
                string Saddress = SupplierAddressTextBox.Text;
                string Sphone = SupplierPhoneTextBox.Text;

                CallSupplier.AddSupplier(Sname, Saddress, Sphone);
            }


        }

        private void UpdateDataSupplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierController CallSupplier = new SupplierController();

            if (SupplierNameTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0 && SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierNameTextBox.Focus();
                SupplierAddressTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0 && SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierNameTextBox.Focus();
                SupplierAddressTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierNameTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierAddressTextBox.Text.Length == 0 && SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierAddressTextBox.Focus();
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierPhoneTextBox.Text.Length == 0)
            {
                SupplierPhoneErrorMessage.Text = "You Must Enter Supplier Phone Number!";
                SupplierPhoneTextBox.Focus();
            }
            else if (SupplierAddressTextBox.Text.Length == 0)
            {
                SupplierAddressErrorMessage.Text = "You Must Enter Supplier Address!";
                SupplierAddressTextBox.Focus();
            }
            else if (SupplierNameTextBox.Text.Length == 0)
            {
                SupplierNameErrorMessage.Text = "You Must Enter Supplier Name!";
                SupplierNameTextBox.Focus();
            }
            else
            {
                string Sname = SupplierNameTextBox.Text;
                string Saddress = SupplierAddressTextBox.Text;
                string Sphone = SupplierPhoneTextBox.Text;

                CallSupplier.UpdateSupplier(Convert.ToInt16((dataGridSupplier.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text), Sname, Saddress, Sphone);
            }
        }

        private void DeleteDataSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Delete Warning!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SupplierController CallSupplier = new SupplierController();

                CallSupplier.DeleteSupplier(Convert.ToInt16((dataGridSupplier.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text));
            }
            else
            {
                MessageBox.Show("Delete Record Successfully Canceled!");
            }
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
            Supplier supplier = new Supplier();
            MyContext _context = new MyContext();
            var get = _context.Suppliers.Where(u => u.isDeleted != true).ToList();

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = get;
        }

        private void dataGridSupplier_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGridSupplier.SelectedCells != null)
            {
                item = dataGridSupplier.SelectedItem;

                SupplierNameTextBox.Text = (dataGridSupplier.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                SupplierAddressTextBox.Text = (dataGridSupplier.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                SupplierPhoneTextBox.Text = (dataGridSupplier.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                VarSetter((dataGridSupplier.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text, (dataGridSupplier.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text, (dataGridSupplier.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
            }
        }

        public void VarSetter(string name, string address, string phone)
        {
            Gname = name;
            Gaddress = address;
            Gphone = phone;
        }

    }

}

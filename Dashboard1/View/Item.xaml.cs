using Dashboard1.Context;
using Dashboard1.Controller;
using Dashboard1.Models;
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
        string email;
        string name;
        string roles;
        private object item;
        public Item(string Uemail, string Uname, string Uroles)
        {
            InitializeComponent();
            GlobalSetter(Uemail, Uname, Uroles);
            LoadSideNavBar(Uroles);
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            Models.Item item = new Models.Item();
            Category category = new Category();
            MyContext _context = new MyContext();
            //var get = _context.Items.Where(u => u.isDeleted != true).ToList();
            var get = _context.Items.Join(_context.Categorys, p => p.Category_Id, s => s.Id, (p, s) => new
            {
                Id = p.Id,
                Name = p.Name,
                Quantity = p.Quantity,
                @Category = s.Name
            }).ToList();

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = get;
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
            Dashboard dashboard = new Dashboard(email, name, roles);
            dashboard.Show();
        }

        private void ItemItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item(email, name, roles);
            item.Show();
        }

        private void ItemCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory category = new MasterCategory(email, name, roles);
            category.Show();
        }

        private void AddDataItem_Click(object sender, RoutedEventArgs e)
        {
            ItemController CallItem = new ItemController();
            //var combo = CategoryComboBox.SelectedValue.ToString();
            //MessageBox.Show(CategoryComboBox.Text);
            if (ItemNameTextBox.Text.Length == 0 && QuantityTextBox.Text.Length == 0 && CategoryComboBox.Text == "" )
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                ItemNameTextBox.Focus();
                QuantityTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0 && QuantityTextBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                ItemNameTextBox.Focus();
                QuantityTextBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0 && CategoryComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                ItemNameTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (QuantityTextBox.Text.Length == 0 && CategoryComboBox.Text == "")
            {
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                QuantityTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemNameTextBox.Focus();
            }
            else if (QuantityTextBox.Text.Length == 0)
            {
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                QuantityTextBox.Focus();
            }
            else if (CategoryComboBox.Text == "")
            {
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                CategoryComboBox.Focus();
            }
            else
            {
                string Iname = ItemNameTextBox.Text;
                int Iqty = Convert.ToInt32(QuantityTextBox.Text);
                int Icat = Convert.ToInt32(CategoryComboBox.SelectedValue.ToString());

                CallItem.AddItem(Iname, Iqty, Icat, email, name, roles);
            }
        }

        private void UpdateDataItem_Click(object sender, RoutedEventArgs e)
        {
            ItemController CallItem = new ItemController();

            if (ItemNameTextBox.Text.Length == 0 && QuantityTextBox.Text.Length == 0 && CategoryComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                ItemNameTextBox.Focus();
                QuantityTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0 && QuantityTextBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                ItemNameTextBox.Focus();
                QuantityTextBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0 && CategoryComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                ItemNameTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (QuantityTextBox.Text.Length == 0 && CategoryComboBox.Text == "")
            {
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                QuantityTextBox.Focus();
                CategoryComboBox.Focus();
            }
            else if (ItemNameTextBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemNameTextBox.Focus();
            }
            else if (QuantityTextBox.Text.Length == 0)
            {
                QuantityErrorMessage.Text = "Item Quantity Can't Be Empty!";
                QuantityTextBox.Focus();
            }
            else if (CategoryComboBox.Text == "")
            {
                CategoryErrorMessage.Text = "You Must Choose Category Item!";
                CategoryComboBox.Focus();
            }
            else
            {
                string Iname = ItemNameTextBox.Text;
                int Iqty = Convert.ToInt32(QuantityTextBox.Text);
                int Icat = Convert.ToInt32(CategoryComboBox.SelectedValue.ToString());

                CallItem.UpdateItem(Convert.ToInt16((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text), Iname, Iqty, Icat);
            }
        }

        private void DeleteDataItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Delete Warning!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SupplierController CallSupplier = new SupplierController();

                CallSupplier.DeleteSupplier(Convert.ToInt16((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text));
            }
            else
            {
                MessageBox.Show("Delete Record Successfully Canceled!");
            }
        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGrid.SelectedCells != null) {
                item = dataGrid.SelectedItem;


                ItemNameTextBox.Text = (dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                QuantityTextBox.Text = (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;

            }
        }

        private void CategoryComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            MyContext _context = new MyContext();
            var get = _context.Categorys.Where(u => u.isDeleted != true).ToList();

            // ... Assign ItemsSource of DataGrid.
            var combo = sender as ComboBox;
            combo.ItemsSource = get;
        }

        private void LoadSideNavBar(string RoleId)
        {
            if (RoleId == "EMP")
            {
                ButtonSupplier.Visibility = Visibility.Collapsed;
                ButtonItem.Visibility = Visibility.Collapsed;
                ButtonCategory.Visibility = Visibility.Collapsed;
            }
            else if (RoleId == "MAN")
            {
                ButtonSupplier.Visibility = Visibility.Collapsed;
                ButtonItem.Visibility = Visibility.Collapsed;
                ButtonCategory.Visibility = Visibility.Collapsed;
            }

        }
        public void GlobalSetter(string Uemail, string Uname, string Uroles)
        {
            email = Uemail;
            name = Uname;
            roles = Uroles;
        }

        private void ItemSupplier(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Supplier supplier = new Supplier(email, name, roles);
            supplier.Show();
        }

        
    }
}

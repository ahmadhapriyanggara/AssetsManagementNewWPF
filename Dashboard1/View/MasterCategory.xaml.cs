using Dashboard1.Context;
using Dashboard1.Controller;
using Dashboard1.Models;
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
    /// Interaction logic for MasterCategory.xaml
    /// </summary>
    public partial class MasterCategory : Window
    {
        string email;
        string name;
        string roles;
        private object item;
        public MasterCategory(string Uemail, string Uname, string Uroles)
        {
            InitializeComponent();
            GlobalSetter(Uemail, Uname, Uroles);
            LoadSideNavBar(Uroles);
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

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            MyContext _context = new MyContext();
            var get = _context.Categorys.Where(u => u.isDeleted != true).ToList();

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = get;
        }

        private void ButtonPowerCategory(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarIconCategory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CategoryItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item(email, name, roles);
            item.Show();
        }

        private void CategoryDashboard(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(email, name, roles);
            dashboard.Show();
        }

        private void CategoryCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory category = new MasterCategory(email, name, roles);
            category.Show();
        }


        private void AddDataCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryController CallCategory = new CategoryController();

            if (CategoryTextBox.Text.Length == 0)
            {
                CategoryNameErrorMessage.Text = "You Must Enter Category Name!";
                CategoryTextBox.Focus();
            }
            else
            {
                string Cname = CategoryTextBox.Text;

                CallCategory.AddCategory(Cname);
            }

        }

        private void UpdateDataCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryController CallCategory = new CategoryController();

            if (CategoryTextBox.Text.Length == 0)
            {
                CategoryNameErrorMessage.Text = "You Must Enter Category Name!";
                CategoryTextBox.Focus();
            }
            else
            {
                string Cname = CategoryTextBox.Text;

                CallCategory.UpdateCategory(Convert.ToInt16((DataGridCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text), Cname);

            }
        }

        private void DeleteDataCategory_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Delete Warning!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CategoryController CallCategory = new CategoryController();

                CallCategory.DeleteCategory(Convert.ToInt16((DataGridCategory.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text));
            }
            else {
                MessageBox.Show("Delete successfully Canceled!");
            }

            

        }

        private void DataGridCategory_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (DataGridCategory.SelectedCells != null)
            {
                item = DataGridCategory.SelectedItem;

                CategoryTextBox.Text = (DataGridCategory.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            }
        }

        private void CategorySupplier(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Supplier supplier = new Supplier(email, name, roles);
            supplier.Show();
        }
    }
}

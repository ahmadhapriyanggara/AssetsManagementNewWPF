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
    /// Interaction logic for ItemDetail.xaml
    /// </summary>
    public partial class ItemDetail : Window
    {
        string email;
        string name;
        string roles;
        public ItemDetail(string Uemail, string Uname, string Uroles)
        {
            InitializeComponent();
            GlobalSetter(Uemail, Uname, Uroles);
        }
        
        public void GlobalSetter(string Uemail, string Uname, string Uroles)
        {
            email = Uemail;
            name = Uname;
            roles = Uroles;
        }

        private void ItemComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Models.Item item = new Models.Item();
            MyContext _context = new MyContext();
            var get = _context.Items.Where(u => u.isDeleted != true).ToList();

            // ... Assign ItemsSource of DataGrid.
            var combo = sender as ComboBox;
            combo.ItemsSource = get;
        }

        private void SupplierComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Supplier supplier = new Supplier(email, name, roles);
            MyContext _context = new MyContext();
            var get = _context.Suppliers.Where(u => u.isDeleted != true).ToList();

            // ... Assign ItemsSource of DataGrid.
            var combo = sender as ComboBox;
            combo.ItemsSource = get;
        }

        private void AddDataItemDetails_Click(object sender, RoutedEventArgs e)
        {
            ItemDetailController CallItem = new ItemDetailController();
            //var combo = CategoryComboBox.SelectedValue.ToString();
            //MessageBox.Show(CategoryComboBox.Text);
            if (SerialNumberTextBox.Text.Length == 0 && ItemConditionTextBox.Text.Length == 0 && ItemComboBox.Text == "" && SupplierComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                ItemComboBox.Focus();
                SupplierComboBox.Focus();
                SerialNumberTextBox.Focus();
                ItemConditionTextBox.Focus();
            }
            else if (ItemConditionTextBox.Text.Length == 0 && ItemComboBox.Text == "" && SupplierComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                ItemComboBox.Focus();
                SupplierComboBox.Focus();
                ItemConditionTextBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0 && ItemComboBox.Text == "" && SupplierComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                ItemComboBox.Focus();
                SupplierComboBox.Focus();
                SerialNumberTextBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0 && ItemConditionTextBox.Text.Length == 0 && SupplierComboBox.Text == "")
            {
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                SupplierComboBox.Focus();
                SerialNumberTextBox.Focus();
                ItemConditionTextBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0 && ItemConditionTextBox.Text.Length == 0 && ItemComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                ItemComboBox.Focus();
                SerialNumberTextBox.Focus();
                ItemConditionTextBox.Focus();
            }
            ///////
            else if (SerialNumberTextBox.Text.Length == 0 && ItemConditionTextBox.Text.Length == 0)
            {
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SerialNumberTextBox.Focus();
                ItemConditionTextBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0 && ItemComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SerialNumberTextBox.Focus();
                ItemComboBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0 && SupplierComboBox.Text == "")
            {
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SerialNumberTextBox.Focus();
                SupplierComboBox.Focus();
            }
            ///////
            else if (ItemConditionTextBox.Text.Length == 0 && SupplierComboBox.Text == "")
            {
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                SerialNumberTextBox.Focus();
                SupplierComboBox.Focus();
            }
            else if (ItemConditionTextBox.Text.Length == 0 && ItemComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                ItemConditionTextBox.Focus();
                ItemComboBox.Focus();
            }
            ///////
            else if (ItemComboBox.Text == "" && SupplierComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                ItemComboBox.Focus();
                SupplierComboBox.Focus();
            }
            ///////
            else if (ItemComboBox.Text == "")
            {
                ItemNameErrorMessage.Text = "Item Name Can't Be Empty!";
                ItemComboBox.Focus();
            }
            else if (SupplierComboBox.Text == "")
            {
                SupplierErrorMessage.Text = "Supplier Can't Be Empty!";
                SupplierComboBox.Focus();
            }
            else if (ItemConditionTextBox.Text.Length == 0)
            {
                ItemConditionErrorMessage.Text = "Item Quantity Can't Be Empty!";
                ItemConditionTextBox.Focus();
            }
            else if (SerialNumberTextBox.Text.Length == 0)
            {
                SerialNumberErrorMessage.Text = "Item Serial Number Can't Be Empty!";
                SerialNumberTextBox.Focus();
            }
            else
            {
                string Snumber = SerialNumberTextBox.Text;
                string Scondition = ItemConditionTextBox.Text;
                int Iitem = Convert.ToInt32(ItemComboBox.SelectedValue.ToString());
                int Isup = Convert.ToInt32(SupplierComboBox.SelectedValue.ToString());

                var result = CallItem.AddItem(Snumber, Scondition, Iitem, Isup);

                if (result == true)
                {
                    MessageBox.Show("Add Data Item Detail Successful!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Add Data Item Detail Failed!");
                }
            }
        }

    }
}

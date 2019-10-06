using Dashboard1.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            FillItem();
            FillDate();
        }

        private void FillItem()
        {
            MyContext _context = new MyContext();
            List<Models.Item> lst = _context.Items.ToList();
            ItemNameComboBox.ItemsSource = lst;
        }

        private void FillDate()
        {
            loan_date.DisplayDateStart = DateTime.Now;
            loan_date.IsTodayHighlighted = true;
        }

        private void ButtonAddDataItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemNameComboBox.Text.Length == 0 && ItemQuantityTextBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "You Must Enter Item Name!";
                ItemQuantityErrorMessage.Text = "You Must Enter Quantity Item";
                ItemQuantityTextBox.Focus();
                ItemNameComboBox.Focus();
            }
            else if (ItemNameComboBox.Text.Length == 0)
            {
                ItemNameErrorMessage.Text = "You Must Enter Item Name!";
                ItemQuantityErrorMessage.Text = "";
                ItemNameComboBox.Focus();
            }
            else if(ItemQuantityTextBox.Text.Length == 0)
            {
                ItemQuantityErrorMessage.Text = "You Must Enter Quantity Item";
                ItemNameErrorMessage.Text = "";
                ItemQuantityTextBox.Focus();
            }
            else
            {
                ItemNameErrorMessage.Text = "";
                ItemQuantityErrorMessage.Text = "";

                using (MyContext _context = new MyContext())
                {
                    var qty = _context.Items.SqlQuery("Select Quantity From Item Where Name ='" + ItemNameComboBox.Text + "'");
                }
                    
                if (Convert.ToInt32(ItemQuantityTextBox.Text) <= 10)
                {
                    
                    var data = new Test { id = Convert.ToInt32(ItemNameComboBox.SelectedValue), name = ItemNameComboBox.Text, quantity = Convert.ToInt32(ItemQuantityTextBox.Text) };
                    dataGridLoanRequest.Items.Add(data);

                }
                else
                {
                    ItemQuantityErrorMessage.Text = "Quantity item is more than stock item";
                }
                
            }
            
        }

        public class Test
        {
            public int id { get; set; }
            public string name { get; set; }
            public int quantity { get; set; }

        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void LoanRequestDashboard(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dashboard NewDashboard = new Dashboard();
            NewDashboard.Show();
        }

        private void LoanRequestCategory(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MasterCategory mastercategory = new MasterCategory();
            mastercategory.Show();
        }

        private void LoanRequestLoanRequest(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoanRequest loanrequest = new LoanRequest();
            loanrequest.Show();
        }

        private void LoanRequestItem(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.Show();
        }

        private void LoanRequestSupplier(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void Loan_date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            return_date.DisplayDateStart = loan_date.SelectedDate;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            DateTime? nullDateTimeLoan;
            DateTime? nullDateTimereturn;
            nullDateTimeLoan = loan_date.SelectedDate;
            nullDateTimereturn = return_date.SelectedDate;
            if(nullDateTimeLoan == null && nullDateTimereturn == null && remark.Text.Length == 0)
            {
                LoanDateErrorMessage.Text = "You Must Enter Loan Date!";
                ReturnDateErrorMessage.Text = "You Must Enter Return Date";
                RemarkErrorMessage.Text = "You Must Enter Remark";
                loan_date.Focus();
                return_date.Focus();
                remark.Focus();
            }
            else if(nullDateTimeLoan == null && nullDateTimereturn == null)
            {
                LoanDateErrorMessage.Text = "You Must Enter Loan Date!";
                ReturnDateErrorMessage.Text = "You Must Enter Return Date";
                RemarkErrorMessage.Text = "";
                loan_date.Focus();
                return_date.Focus();
            }
            else if (nullDateTimeLoan == null && remark.Text.Length == 0)
            {
                LoanDateErrorMessage.Text = "You Must Enter Loan Date!";
                ReturnDateErrorMessage.Text = "";
                RemarkErrorMessage.Text = "You Must Enter Remark";
                loan_date.Focus();
                remark.Focus();
            }
            else if (nullDateTimereturn == null && remark.Text.Length == 0)
            {
                LoanDateErrorMessage.Text = "";
                ReturnDateErrorMessage.Text = "You Must Enter Return Date";
                RemarkErrorMessage.Text = "You Must Enter Remark";
                return_date.Focus();
                remark.Focus();
            }
            else if (nullDateTimeLoan == null)
            {
                LoanDateErrorMessage.Text = "You Must Enter Loan Date!";
                ReturnDateErrorMessage.Text = "";
                RemarkErrorMessage.Text = "";
                loan_date.Focus();
            }
            else if (nullDateTimereturn == null)
            {
                LoanDateErrorMessage.Text = "";
                ReturnDateErrorMessage.Text = "You Must Enter Return Date";
                RemarkErrorMessage.Text = "";
                return_date.Focus();
            }
            else if (remark.Text.Length == 0)
            {
                LoanDateErrorMessage.Text = "";
                ReturnDateErrorMessage.Text = "";
                RemarkErrorMessage.Text = "You Must Enter Remark";
                remark.Focus();
            }
            else
            {
                
                foreach(DataRow dr in dataGridLoanRequest)
                {

                }
            }
        }
    }
}

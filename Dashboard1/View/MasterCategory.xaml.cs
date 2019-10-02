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
        public MasterCategory()
        {
            InitializeComponent();
            //Category category = new Category();
            //DataContext = new CategoryViewModel(category);
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
            MainWindow NewDashboard = new MainWindow();
            NewDashboard.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.Show();
        }
    }

    //internal class CategoryViewModel
    //{
    //    public List<Category> Category { get; private set; }

    //    public CategoryViewModel(Category category)
    //    {
    //        Category = new List<Category>();
    //        Category.Add(category);
    //    }
    //}

    //internal class Category
    //{
    //    public string Test { get; private set; }
    //    public int Percentage { get; private set; }

    //    public Category()
    //    {
    //        Test = "Consumo Atual";
    //        Percentage = CalculatePercentage();
    //    }

    //    private int CalculatePercentage()
    //    {
    //        return 47; //Calculo da porcentagem de consumo
    //    }
    //}

    class Transaksi_Loan
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }

        public Transaksi_Loan(int id, string iname, DateTime LDate, DateTime RDate, string remark, string status)
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

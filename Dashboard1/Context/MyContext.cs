using Dashboard1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("DbConnectionString")
        {

        }

        public DbSet<Approve_Status> Approves_Status { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee_Role> Employee_Roles { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Item_Loan> Item_Loans { get; set; }
        public DbSet<Item_Return_Status> Return_Status_Items { get; set; }
        public DbSet<Item_Supplier> Item_Suppliers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Loan_Approve_Status> Loans_Approve_Status { get; set; }
        public DbSet<Return_Status> Returns_Status { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        
        

    }
}

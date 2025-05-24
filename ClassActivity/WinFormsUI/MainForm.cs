using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DAL;
using BLL;

namespace WinFormsUI
{
    public partial class MainForm : Form
    {
        private readonly CustomerService _customerService;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerService = new CustomerService();
            this.btnLoad.Click += new System.EventHandler(btnLoad_Click);
            this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
            this.btnFind.Click += new System.EventHandler(btnFind_Click);
            Customer_Load();
        }
        private void Customer_Load()
        {
            var customers = _customerService.GetAllCustomers();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            foreach (var customer in customers)
            {
                table.Rows.Add(customer.Id, customer.Name, customer.Email);
            }
            customerGridView.DataSource = table;
        }

        private void Load_Data()
        {
            Customer_Load();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            var customerId = Convert.ToInt32(txtCustomerID.Text);
            var customer = _customerService.GetCustomerById(customerId);
            if (customer != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Rows.Add(customer.Id, customer.Name, customer.Email);
                customerGridView.DataSource = table;
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e) 
        {
            Load_Data();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();   
            addNewCustomerForm.Show();
            this.Hide();
        }

    }
}

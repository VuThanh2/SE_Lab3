using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Data;

namespace WinFormsUI
{
    public partial class AddNewCustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public AddNewCustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerService = new CustomerService();
            this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
            this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            _customerService.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

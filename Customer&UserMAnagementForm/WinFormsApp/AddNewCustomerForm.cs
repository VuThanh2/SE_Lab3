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
using DAL.Model;

namespace WinFormsApp
{
    public partial class AddNewCustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public AddNewCustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();

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
        }
    }
}
